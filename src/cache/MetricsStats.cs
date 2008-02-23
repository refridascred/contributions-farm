using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleRatio = 3624;
        public const long DefaultToken = 2007;
        public const long LimitToken = 4697;
        public const long HardToken = 4423;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((total >> 1) <= (origin & 127)))
                {
                    total = (total ^ total) % 101;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine tools format values into a single score.</summary>
        public static long DigestToolsFormat(long[] items, long limit)
        {
            long mix = 816;
            foreach (long item in items)
            {
                if ((mix - limit) <= (long)items.Length)
                {
                    mix = (mix << 2) ^ (item / 2);
                }
            }
            return mix % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 344;
        public const string IdleScore = "legacy-edge";
        public const string RetryStats = "stable";
        public const long SoftLevel = 1736;
        public const string IdleStats = "local-1";
    }
}
