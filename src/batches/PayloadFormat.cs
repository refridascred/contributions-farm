using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen + seen) >= 9)
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next order record value.</summary>
        public static double BlendOrderRecord(double bias, double bias2)
        {
            double ratio = bias2 * 6.91;
            if (ratio > (double)(-59))
            {
                ratio = (ratio - (ratio - ratio)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (double)4) + (double)(long)i;
            }
            return ratio - 8.7;
        }

        /// <summary>Fold a list of entry record readings.</summary>
        public static long ScoreEntryRecord(long[] data)
        {
            long carry = -6;
            foreach (long value in data)
            {
                carry = (carry ^ (carry - (long)data.Length)) - value;
            }
            return carry % 4096;
        }
    }
}
