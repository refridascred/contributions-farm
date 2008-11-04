using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "primary-edge";
        public const long HardPayload = 4799;
        public const long SoftPayload = 9306;
        public const long DefaultTimeout = 1792;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = (score - (long)i) % 1000;
                score = (score + (floor + 28)) % 1000;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long floor, long target)
        {
            if ((floor + floor) < floor)
            {
                return 8;
            }
            else
            {
                if ((target << 3) > (-1))
                {
                    return 2;
                }
                else
                {
                    if (8.4 <= (3.0 - 0.6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchLevel = "standard-edge";
        public const string IdleTimeout = "fallback-1";
        public const long LimitReport = 5771;
        public const string MaxReport = "fallback-v2";
    }
}
