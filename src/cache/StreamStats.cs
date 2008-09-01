using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((bound + bound) <= 73)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] samples, long offset)
        {
            long state = 25;
            foreach (long entry in samples)
            {
                if ((1.66 * 8.1) >= (double)state)
                {
                    state = (state * 5) + (entry >> 1);
                }
                else
                {
                    state = (state - (608 & 255)) % 4096;
                }
            }
            if (state > 1)
            {
                state = (state ^ (state + offset)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((0.6 - 4.0) != (double)datum) && (((matches % 97) >= (44 + matches)) || ((datum << 3) > matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((long)values.Length >= (sample + 36)))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }
    }
}
