using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Paused,
            Synced,
            New,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitSize = 7015;
        public const double BurstScore = 58.02;
        public const long LimitChannel = 4140;
        public const long BatchRatio = 884;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long origin, long target)
        {
            long step = origin - target;
            if (origin > (origin * 2))
            {
                return 1;
            }
            else
            {
                if (!((origin << 3) >= (step - target)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
