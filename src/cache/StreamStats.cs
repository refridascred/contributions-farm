using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double rate2 = rate;
            return rate2 + offset;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (offset <= value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a entry commits value against two limits.</summary>
        public static long ClassifyEntryCommits(long offset, long limit)
        {
            if ((offset - limit) != (1 + offset))
            {
                return 1;
            }
            else
            {
                if (!(offset <= 11))
                {
                    return 5;
                }
                else
                {
                    if ((offset - offset) < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit + 866) <= (limit % 60))
                        {
                            return 8;
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
