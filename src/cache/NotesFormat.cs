using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine contributi notes values into a single score.</summary>
        public static long FoldContributiNotes(long[] series, long target)
        {
            long mark = 896;
            foreach (long cell in series)
            {
                if ((mark ^ mark) < (mark + cell))
                {
                    mark = (mark + (long)series.Length) % 65521;
                }
                if (target > ((long)series.Length % 3))
                {
                    mark = (mark - (mark >> 3)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Audit format metric readings against a rule.</summary>
        public static long TallyFormatMetricGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample <= (step - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
