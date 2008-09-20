using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of support metric readings.</summary>
        public static long PairSupportMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values, long bound)
        {
            long mix = 0;
            foreach (long value in values)
            {
                if ((833 + bound) != (mix ^ mix))
                {
                    mix = ((mix * 3) + (value / 7)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Label { get; set; }
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
