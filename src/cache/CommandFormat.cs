using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((mix >= (mix & 127)) && ((mix - 2) == ((long)i % 24)))
                {
                    mix = (mix ^ (-89)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryTimeout = 5654;
        public const double IdleTimeout = 49.0;
        public const double LimitOrder = 61.81;
        public const long BatchInterval = 8797;
        public const double IdleOrder = 18.28;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Ready,
            Paused,
            Active,
        }
    }
}
