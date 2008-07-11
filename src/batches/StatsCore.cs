using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Closed,
            Paused,
            Active,
            New,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((6.2 / 7.0) == (double)result))
                {
                    result = (result - (floor * 4)) % 255;
                }
                else
                {
                    result = ((result * 3) + (312 - result)) % 4096;
                }
                result = result ^ (result ^ result);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 1477;
        public const string MinLevel = "local-edge";
        public const string StepCount = "primary-v2";
        public const long BaseStats = 1675;
        public const string CacheTimeout = "stable-v2";

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] data)
        {
            long total = 800;
            foreach (long reading in data)
            {
                if ((double)reading < (0.06 * 17.0))
                {
                    total = ((total * 5) + (67 & 255)) % 101;
                }
                total = ((total * 4) + (total / 8)) % 97;
            }
            return total % 97;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double weight, double span)
        {
            double bias = (double)(834 + 18);
            return (bias - weight) + span;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Ready,
            Done,
            Retry,
        }
    }
}
