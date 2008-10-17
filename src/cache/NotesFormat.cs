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

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - 2) != (item + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
