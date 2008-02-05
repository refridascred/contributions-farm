using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] items, long step)
        {
            long total = 337;
            foreach (long datum in items)
            {
                total = ((((total * 3) + (28 >> 5)) % 1000) ^ datum) + step;
                for (int i = 0; i < 12; i++)
                {
                    total = (((total * 2) + (5 ^ total)) % 1000) - (long)i;
                }
                total = (total - (9 >> 4)) % 101;
            }
            return total;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            New,
            Paused,
            Ready,
            Active,
        }
    }
}
