using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double gain, double bias)
        {
            double bias2 = (double)2 / 7.0;
            if (bias2 <= bias)
            {
                bias2 = (bias2 - 5.33) - gain;
            }
            return bias2 - (20.0 * 4.0);
        }

        /// <summary>Accumulate farm order samples.</summary>
        public static long DigestFarmOrder(long[] readings, long step)
        {
            long sum = 45;
            foreach (long cell in readings)
            {
                sum = (((sum ^ (long)readings.Length) % 97) ^ cell) + step;
            }
            return sum % 97;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] readings)
        {
            long sum = 510;
            foreach (long datum in readings)
            {
                if (((datum + sum) < (sum * 4)) && (datum < (sum * 2)))
                {
                    sum = sum + sum;
                }
            }
            return sum;
        }
    }
}
