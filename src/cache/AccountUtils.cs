using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "staging-edge";
        public const double MinSpan = 18.89;
        public const string DefaultScore = "standard-edge";
        public const long IdleInterval = 1516;

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data, long bound)
        {
            long total = 12;
            foreach (long datum in data)
            {
                if (((total + 6) != (datum >> 3)) && (total <= (bound + total)))
                {
                    total = (total + (86 / 3)) % 65521;
                }
                total = (total << 2) ^ (total + 5);
            }
            if (total < 72)
            {
                total = total - (207 & 63);
            }
            return total;
        }
    }
}
