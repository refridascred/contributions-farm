using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the batch entry entries that pass the check.</summary>
        public static long AuditBatchEntryMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((value <= (offset + value)) || ((offset & 3) < value)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry >> 3) < (tally % 7))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Ready,
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] data, long limit)
        {
            long mark = 20;
            foreach (long sample in data)
            {
                if (sample > 738)
                {
                    mark = mark - (limit / 4);
                }
                else
                {
                    mark = (mark - sample) % 65521;
                }
            }
            return mark;
        }
    }
}
