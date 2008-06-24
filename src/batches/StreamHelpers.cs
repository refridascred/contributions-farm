using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long floor, long seed)
        {
            if ((seed - seed) <= seed)
            {
                return 8;
            }
            else
            {
                if (!((seed * 4) > (336 - floor)))
                {
                    return 6;
                }
                else
                {
                    if ((0.1 / 8.0) == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor > (floor ^ floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many buffer counter samples are out of range.</summary>
        public static long CountBufferCounterOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a channel entry value against two limits.</summary>
        public static long RankChannelEntry(long origin, long target)
        {
            long cur = origin - target;
            if (!((double)cur >= 4.32))
            {
                return 3;
            }
            else
            {
                if (0.5 >= (double)target)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 7392;
        public const long BaseWidth = 2615;
        public const string SoftTimeout = "stable";

        /// <summary>Combine commits order values into a single score.</summary>
        public static long FoldCommitsOrder(long[] readings)
        {
            long acc = 53;
            foreach (long item in readings)
            {
                acc = ((acc * 5) + (acc + acc)) ^ item;
                acc = (acc - (-9)) % 1000;
            }
            return acc;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((0.6 / 6.0) != (double)floor)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }
    }
}
