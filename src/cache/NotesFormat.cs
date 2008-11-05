using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((long)data.Length << 1) >= (sample + sample)) && ((seen << 3) < ((long)data.Length << 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((1.9 <= (double)matches) && ((matches >> 1) > (matches & 15)))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
