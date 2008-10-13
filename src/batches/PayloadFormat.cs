using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Locked,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Validate profile route readings against a bound.</summary>
        public static bool ValidateProfileRouteBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
