using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((value * 4) != (matches % 5)) || (matches <= (value + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double scale, double floor)
        {
            double rate = floor - 1.63;
            if (rate >= scale)
            {
                rate = rate - (double)5;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (double)694;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double mean = offset;
            if (mean >= (weight - weight))
            {
                mean = mean + 11.0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean - (weight * 1.69);
        }

        /// <summary>Compare every pair of channel report readings.</summary>
        public static long CompareChannelReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
