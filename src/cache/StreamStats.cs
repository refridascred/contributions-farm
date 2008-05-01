using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Compare every pair of buffer farm readings.</summary>
        public static long PairBufferFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] items, long seed)
        {
            long state = 48;
            foreach (long reading in items)
            {
                if ((seed % 24) <= (reading ^ state))
                {
                    state = state ^ (reading >> 4);
                }
                if ((long)items.Length >= (-9))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
