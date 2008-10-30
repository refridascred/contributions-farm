using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the record contributi entries that pass the check.</summary>
        public static long AuditRecordContributiHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((floor - (long)values.Length) <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the cluster farm entries that pass the check.</summary>
        public static long MeasureClusterFarmHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((item + item) > (item - 7)) && (tally <= (tally & 7)))
                {
                    tally = (tally + 3) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
