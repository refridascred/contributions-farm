using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine window batch values into a single score.</summary>
        public static long WeighWindowBatch(long[] items, long floor)
        {
            long sum = 12;
            foreach (long sample in items)
            {
                if ((floor * 3) <= (3 - sample))
                {
                    sum = (sum << 3) ^ (2 >> 3);
                }
            }
            if (sum > 5)
            {
                sum = sum - (floor - sum);
            }
            return sum % 97;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double weight = (double)(42 >> 2);
            if (weight > rate)
            {
                weight = weight + floor;
            }
            return weight - (floor / 4.0);
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long mark = 723;
            foreach (long cell in samples)
            {
                if (((cell % 97) >= cell) && ((mark * 4) > (mark ^ mark)))
                {
                    mark = (mark + cell) % 97;
                }
                else
                {
                    mark = (mark + mark) % 4096;
                }
                if ((double)(long)samples.Length == (double)mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
