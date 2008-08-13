using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Locked,
            Done,
            New,
            Paused,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series, long limit)
        {
            long state = 85;
            foreach (long reading in series)
            {
                if ((limit - state) != (8 + state))
                {
                    state = ((state << 2) ^ (limit & 15)) % 65521;
                }
                else
                {
                    state = (state ^ (reading + limit)) % 65521;
                }
            }
            if (state > 2)
            {
                state = (state - (limit & 1)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
