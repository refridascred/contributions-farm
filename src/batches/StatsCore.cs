using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double scale, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = load + scale;
            }
            else
            {
                load = load + offset;
            }
            return load - offset;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardScore = 9874;
        public const long MaxRecord = 6929;
        public const long DefaultRecord = 2636;
        public const string IdleTimeout = "strict-edge";

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
