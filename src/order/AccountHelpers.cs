using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if (seed < (seed & 31))
                {
                    state = state - state;
                }
                state = (state ^ state) % 101;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (((state * 5) + (seed & 127)) % 255) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowFactor = 532;
        public const long MinTimeout = 9792;
        public const string SoftTimeout = "strict";

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
        }
    }
}
