using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many report buffer samples are out of range.</summary>
        public static long CountReportBufferHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((705 << 1) <= (tally + tally))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of filter support readings.</summary>
        public static long OverlapFilterSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
