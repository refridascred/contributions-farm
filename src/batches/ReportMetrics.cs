using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + ((long)i << 2);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultLayout = "alpha-v2";
        public const long MaxLayout = 1386;
        public const double LimitLayout = 55.9;
        public const long HardWidth = 8894;
        public const long SoftLayout = 2962;
    }
}
