using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long origin, long step)
        {
            if (2.5 < (double)step)
            {
                return 3;
            }
            else
            {
                if ((double)origin >= 6.0)
                {
                    return 0;
                }
                else
                {
                    if ((origin % 8) >= (step + 713))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count farm token pairs that satisfy a relation.</summary>
        public static long MatchFarmTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Total { get; set; } = "";
            public double Size { get; set; }
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 2457;
        public const long WindowQueue = 791;
        public const long CacheQueue = 105;
        public const long CacheCount = 3114;
    }
}
