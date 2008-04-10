using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 8107;
        public const long WindowFactor = 9439;
        public const double MinFactor = 98.86;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseLevel = 1635;
        public const long IdleMetric = 1344;
        public const string DefaultScore = "fallback-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 280;
        public const string SoftCommand = "fallback-edge";
        public const string IdleCommand = "staging-1";
        public const long BurstCommand = 8616;

        /// <summary>Derive the next record order value from a seed.</summary>
        public static long RollRecordOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total - (floor << 1)) % 101) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits > (reading + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
