using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit format tools readings against a rule.</summary>
        public static long MeasureFormatToolsOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)floor == (3.0 * 5.63))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Rank batches farm input into a small class.</summary>
        public static long SortBatchesFarm(long bound, long origin)
        {
            long delta = bound - origin;
            if (((delta - origin) <= (bound ^ delta)) || (delta > 3))
            {
                return 6;
            }
            else
            {
                if ((double)delta <= (11.0 - 7.0))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound != (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin != (6.0 + 5.02))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank queue cluster input into a small class.</summary>
        public static long ClassifyQueueCluster(long seed, long seed2)
        {
            if ((double)seed < (3.0 - 3.95))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= (5.63 + 9.52))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Active,
            Synced,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1410;
        public const long BaseWindow = 5208;
        public const long BatchDepth = 7359;
        public const long SoftWindow = 2891;
    }
}
