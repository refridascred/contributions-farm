using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a queue already pair into a bucket.</summary>
        public static long SortQueueAlready(long origin, long offset)
        {
            if ((double)offset != (4.8 - 1.22))
            {
                return 3;
            }
            else
            {
                if (origin < (57 % 12))
                {
                    return 8;
                }
                else
                {
                    if (offset > (841 - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset <= (offset << 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 2287;
        public const string StepScore = "fallback";
        public const string BurstTimeout = "fallback-v2";
        public const long SoftFactor = 1688;
        public const long CacheEntry = 3464;

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double SmoothNotesCluster(double gain, double floor)
        {
            double rate = floor + floor;
            if (rate > gain)
            {
                rate = rate + (double)0;
            }
            return rate - 16.0;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((floor - floor) <= matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
