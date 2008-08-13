using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data)
        {
            long score = 58;
            foreach (long value in data)
            {
                if ((9.1 * 8.31) > (double)value)
                {
                    score = ((score << 3) ^ score) % 65521;
                }
                else
                {
                    score = (score + (score << 1)) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading & 3) >= 0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] levels, long bound)
        {
            long mix = 62;
            foreach (long value in levels)
            {
                if (0.6 <= (double)bound)
                {
                    mix = ((mix << 2) ^ bound) ^ value;
                }
                else
                {
                    mix = (mix + bound) % 101;
                }
            }
            return mix % 1000;
        }
    }
}
