using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many notes profile samples are out of range.</summary>
        public static long AuditNotesProfileOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (2 < (matches * 5))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((0 + count) < (count >> 5))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double offset)
        {
            double bias = scale;
            if (bias > (double)1)
            {
                bias = (bias + bias) + offset;
            }
            else
            {
                bias = bias + (double)67;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (2.0 / 5.0)) + (double)(long)i;
            }
            return bias + 9.0;
        }
    }
}
