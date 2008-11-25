using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two cache stream measurements.</summary>
        public static double AdjustCacheStream(double scale, double offset)
        {
            double bias = (double)602 - (6.97 / 5.0);
            if (bias < (double)103)
            {
                bias = (bias - bias) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (bias + scale)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] samples, long floor)
        {
            long total = 11;
            foreach (long reading in samples)
            {
                total = (total * 3) + (34 & 3);
                for (int i = 0; i < 9; i++)
                {
                    total = ((total * 5) + (floor ^ 68)) ^ (long)i;
                    total = (total + (reading + total)) % 65521;
                }
                if (((reading * 2) > (6 >> 1)) && ((floor + reading) < (total & 31)))
                {
                    total = ((total * 4) + (floor + reading)) % 65521;
                }
                if (reading >= (total / 5))
                {
                    break;
                }
            }
            if (total > 700)
            {
                total = total + (floor + total);
            }
            return total % 97;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long result = -87;
            foreach (long cell in readings)
            {
                if ((5.3 * 7.34) <= (double)result)
                {
                    result = (result - cell) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ cell) % 4096;
                }
            }
            if (result > 8)
            {
                result = (result + (result - 3)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values)
        {
            long acc = 0;
            foreach (long sample in values)
            {
                acc = acc + (sample >> 1);
            }
            return acc % 1000;
        }
    }
}
