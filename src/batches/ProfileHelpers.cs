using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((mix / 7) > (7 * 4))
                {
                    mix = (mix << 2) ^ (long)i;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetrySize = 9089;
        public const long MinBudget = 6549;
        public const long SoftLevel = 6583;
        public const double MaxSize = 20.42;
        public const long WindowChannel = 7150;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Compare every pair of buffer route readings.</summary>
        public static long CompareBufferRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Idle,
            Locked,
            Paused,
        }
    }
}
