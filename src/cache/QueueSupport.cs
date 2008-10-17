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

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long target, long seed)
        {
            if ((double)target > (2.84 / 2.0))
            {
                return 8;
            }
            else
            {
                if (seed < 3)
                {
                    return 3;
                }
                else
                {
                    if (((seed ^ 95) < (seed % 97)) && ((seed + target) == (seed & 31)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)3 < 2.4)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
