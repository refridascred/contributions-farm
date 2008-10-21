using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Score { get; set; } = "";
            public double Region { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit graph token readings against a rule.</summary>
        public static long TallyGraphTokenHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item == (12.0 + 4.0))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
