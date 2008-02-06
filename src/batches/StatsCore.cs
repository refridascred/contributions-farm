using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Done,
            Idle,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Active,
            Failed,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
