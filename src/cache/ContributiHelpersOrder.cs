using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many route farm samples are out of range.</summary>
        public static long TallyRouteFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((3.18 - 5.3) == (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
