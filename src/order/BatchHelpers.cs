using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the graph cluster entries that pass the check.</summary>
        public static long TallyGraphClusterOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)limit == (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
