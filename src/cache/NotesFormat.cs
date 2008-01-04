using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((step + reading) > (seen + seen)) || ((seen >> 4) == (reading - seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a metrics window sample.</summary>
        public static long LocateMetricsWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((7.0 / 9.0) > (double)target)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
