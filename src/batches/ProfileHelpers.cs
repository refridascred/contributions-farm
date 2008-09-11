using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardScore = 4808;
        public const long IdleGraph = 9280;
        public const string BatchGraph = "latest";

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Locked,
            Failed,
            Draft,
        }

        /// <summary>Roll a command order counter forward.</summary>
        public static long SeriesCommandOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
