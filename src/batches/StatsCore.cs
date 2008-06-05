using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((step % 100) == (610 * 5))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits >= (sample & 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardRatio = 7320;
        public const long WindowContributi = 9853;
        public const long SoftTimeout = 3631;
        public const string RetryContributi = "alpha-1";
        public const long MinContributi = 4337;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels, long seed)
        {
            long total = 0;
            foreach (long item in levels)
            {
                if ((37 >= seed) && (item >= (seed - 0)))
                {
                    total = ((total << 3) ^ (seed & 127)) % 97;
                }
                else
                {
                    total = (total - (item << 2)) % 1000;
                }
            }
            if (total > 3)
            {
                total = total + (seed ^ 14);
            }
            return total;
        }
    }
}
