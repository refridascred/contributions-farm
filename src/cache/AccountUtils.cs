using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardLevel = 7065;
        public const long MinCommand = 8511;
        public const string MaxCommand = "standard";
        public const string IdleInterval = "staging-1";
        public const double WindowCount = 31.73;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                bool flag = ((result - 6) > (result + result)) && ((result / 7) > (target + target));
                if (flag)
                {
                    result = (result - (result + (long)i)) % 255;
                }
                else
                {
                    result = (result ^ ((long)i >> 1)) % 97;
                }
                result = ((result << 2) ^ target) % 255;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Queued,
            Ready,
            Idle,
            Active,
        }
    }
}
