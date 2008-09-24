using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitLevel = 2941;
        public const string LimitTimeout = "fallback";
        public const long HardFactor = 9336;
        public const string WindowGraph = "open-edge";
        public const double LimitCount = 55.87;

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] readings)
        {
            long score = 6;
            foreach (long value in readings)
            {
                if (((value - score) > (long)readings.Length) && ((3 * 4) == (value * 3)))
                {
                    score = (score - (value + 772)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long step)
        {
            if ((37 + origin) > (origin >> 1))
            {
                return 3;
            }
            else
            {
                if ((80 + origin) < (step * 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin > 13.0)
                    {
                        return 4;
                    }
                    else
                    {
                        if (step < (origin + (-1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
