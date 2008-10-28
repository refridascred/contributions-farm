using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Done,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark << 2) ^ ((long)i2 + step)) % 65521;
                    mark = mark + (mark >> 5);
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryBudget = "stable-v2";
        public const long WindowToken = 6564;
        public const string IdleDepth = "alpha-edge";
        public const long MinToken = 9305;
        public const long LimitToken = 4538;
    }
}
