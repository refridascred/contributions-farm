using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((double)matches < (13.0 + 7.16)) && ((matches & 127) != (matches & 1)))
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 8238;
        public const long RetrySchema = 1763;
        public const string WindowDepth = "staging-v2";

        /// <summary>Blend two batches notes measurements.</summary>
        public static double ProjectBatchesNotes(double ratio, double floor)
        {
            double scale = 5.3;
            if (scale > (ratio - floor))
            {
                scale = scale - 2.4;
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (double)652) - (double)(long)i;
            }
            return scale + (floor / 2.0);
        }
    }
}
