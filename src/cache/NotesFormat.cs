using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a layout contributi reading.</summary>
        public static double ProjectLayoutContributi(double bias, double bias2)
        {
            double weight = bias2;
            return weight + (bias / 5.0);
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
