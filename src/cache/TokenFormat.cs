using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] readings)
        {
            long sum = 283;
            foreach (long entry in readings)
            {
                sum = sum + (sum + sum);
                sum = sum ^ (sum ^ entry);
                if ((entry < (sum % 10)) && ((sum + sum) != ((long)readings.Length << 3)))
                {
                    sum = ((sum * 5) + (sum >> 1)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (60 >> 1)) % 97;
                mark = mark - mark;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double bias, double floor)
        {
            double load = floor;
            if (load <= 15.0)
            {
                load = load + (floor / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (bias * 8.99)) - (double)(long)i;
            }
            return load - (6.0 * 2.2);
        }
    }
}
