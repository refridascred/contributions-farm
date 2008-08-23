using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
        }
    }
}
