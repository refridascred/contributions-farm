using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Owner { get; set; }
            public bool Score { get; set; }
            public bool Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            Pending,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch payload readings against a rule.</summary>
        public static long TallyBatchPayloadHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > (8.0 * 17.0))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Dropped,
            Done,
            Idle,
        }
    }
}
