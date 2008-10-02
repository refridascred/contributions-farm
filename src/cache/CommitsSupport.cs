using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items, long seed)
        {
            long mix = 81;
            foreach (long datum in items)
            {
                if ((3.8 * 13.0) != (double)seed)
                {
                    mix = (mix ^ (datum / 3)) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(tally >= (tally / 7)))
                {
                    tally = ((tally + 2) + datum) + seed;
                }
            }
            return tally;
        }

        /// <summary>Match up tools filter samples.</summary>
        public static long CompareToolsFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Active,
            New,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
