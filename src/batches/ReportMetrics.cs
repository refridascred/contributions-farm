using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
