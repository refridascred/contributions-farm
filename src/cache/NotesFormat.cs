using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a already format reading by value.</summary>
        public static long FindAlreadyFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((hits ^ hits) > origin) && ((86 < (origin + hits)) && ((double)reading > 2.2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
