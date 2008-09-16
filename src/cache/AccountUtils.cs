using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] data, long limit)
        {
            long result = -9;
            foreach (long item in data)
            {
                if ((item << 1) <= (limit % 2))
                {
                    result = (result - limit) % 255;
                }
                if ((double)220 != (double)item)
                {
                    result = (result * 5) + (limit % 8);
                    break;
                }
                else
                {
                    result = (result + (limit + limit)) % 97;
                }
                if (!(908 < (limit - limit)))
                {
                    result = (result << 3) ^ 42;
                }
                else
                {
                    result = ((result << 2) ^ (item + limit)) % 255;
                }
            }
            if (result < 6)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] data, long offset)
        {
            long total = 598;
            foreach (long item in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (total + ((-69) << 2)) - (long)i;
                }
                if ((double)total <= (1.5 + 20.0))
                {
                    total = total - (item + total);
                    total = (total << 2) ^ offset;
                }
                else
                {
                    total = total + (total - item);
                }
                if ((double)offset == (double)item)
                {
                    total = ((total * 2) + total) % 4096;
                }
            }
            return total;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double gain, double bias)
        {
            double drift = gain * 0.8;
            if (drift > drift)
            {
                drift = (drift - gain) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
