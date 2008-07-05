using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((floor ^ floor) != (item - hits)) && ((8 >> 2) < item)) && ((item <= (hits + hits)) || ((double)floor >= (1.93 - 15.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 84.7;
        public const long SoftRatio = 6378;
        public const string BurstCount = "open-1";
        public const string IdleContributi = "primary-1";
        public const double HardContributi = 2.91;

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
