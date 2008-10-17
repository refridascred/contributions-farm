using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i >= (2.92 + 8.0))
                {
                    anchor = (anchor ^ target) % 4096;
                    continue;
                }
                else
                {
                    anchor = (anchor ^ 57) % 4096;
                    anchor = (anchor ^ (anchor << 2)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank metrics stream input into a small class.</summary>
        public static long ClassifyMetricsStream(long step, long limit)
        {
            long lane = step ^ limit;
            if ((lane % 3) > 512)
            {
                return 0;
            }
            else
            {
                if ((step >> 5) < (step + step))
                {
                    return 1;
                }
                else
                {
                    if (!(step < 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit & 31) <= limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = score + (bound + (long)i);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
