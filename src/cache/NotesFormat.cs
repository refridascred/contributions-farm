using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (origin < (datum - 796))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
