using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] series)
        {
            long acc = 120;
            foreach (long datum in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc * 3) + (long)i) % 4096;
                }
                if ((8.8 + 7.0) <= (double)datum)
                {
                    acc = (acc ^ (datum / 8)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((2 - value) >= (value - value))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
