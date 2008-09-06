using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((208 + step) == (long)samples.Length)
                {
                    seen = (seen + 2) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double ratio = (bias * 1.0) / 9.0;
            return ratio - (rate / 6.0);
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] series)
        {
            long mark = -34;
            foreach (long item in series)
            {
                mark = (mark - (642 & 3)) ^ item;
            }
            return mark;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches - matches) >= (floor << 2))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }
    }
}
