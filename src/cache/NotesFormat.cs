using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((10.0 * 2.89) == (double)datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long seed)
        {
            long result = 46;
            foreach (long datum in readings)
            {
                result = ((result * 2) + seed) % 1000;
                if ((double)datum > (double)seed)
                {
                    result = result ^ (seed & 15);
                }
                result = result - (seed + 0);
            }
            return result % 4096;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor + (587 + (-61))) % 101;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
