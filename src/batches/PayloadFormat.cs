using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate editor session samples.</summary>
        public static long WeighEditorSession(long[] items, long target)
        {
            long acc = 9;
            foreach (long value in items)
            {
                if ((443 % 12) >= (acc & 15))
                {
                    acc = (((acc ^ ((-75) / 6)) % 4096) ^ value) - target;
                }
                else
                {
                    acc = (acc * 5) + acc;
                }
            }
            return acc;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 > (double)36)
            {
                scale2 = (scale2 + 7.36) - scale;
            }
            else
            {
                scale2 = scale2 + (double)295;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + 6.0) - (double)(long)i;
            }
            return scale2 + bias;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] samples)
        {
            long carry = 52;
            foreach (long reading in samples)
            {
                if ((reading - carry) > (reading + 6))
                {
                    carry = (carry + reading) % 65521;
                }
            }
            if (carry > (-894))
            {
                carry = (carry ^ ((long)samples.Length + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum - 559) <= (seed >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
