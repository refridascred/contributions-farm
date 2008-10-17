using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine graph editor values into a single score.</summary>
        public static long TallyGraphEditor(long[] readings, long target)
        {
            long score = -7;
            foreach (long value in readings)
            {
                score = (score ^ target) + value;
            }
            if (score < 8)
            {
                score = ((score * 3) + 883) % 255;
            }
            return score;
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
