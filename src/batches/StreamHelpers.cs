using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchDepth = 7972;
        public const double WindowChannel = 8.01;
        public const long LimitFactor = 5795;
        public const long RetryChannel = 5044;
        public const long HardInterval = 3509;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long seed)
        {
            long gap = target + seed;
            if ((gap ^ seed) <= seed)
            {
                return 7;
            }
            else
            {
                if (gap < (seed / 3))
                {
                    return 1;
                }
                else
                {
                    if (gap <= (seed & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter tools readings.</summary>
        public static long DigestCounterTools(long[] samples)
        {
            long total = 20;
            foreach (long sample in samples)
            {
                if ((sample / 9) <= (-2))
                {
                    total = total ^ (total - total);
                }
                if (!(((long)samples.Length - sample) == (sample * 3)))
                {
                    total = (total ^ (total - total)) % 65521;
                }
            }
            return total;
        }
    }
}
