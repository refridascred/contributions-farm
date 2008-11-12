using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] readings, long limit)
        {
            long carry = 9;
            foreach (long entry in readings)
            {
                if ((limit <= entry) && ((-62) > (entry + carry)))
                {
                    carry = (carry + (limit - entry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] readings, long bound)
        {
            long carry = 703;
            foreach (long datum in readings)
            {
                if (((-85) ^ bound) <= 369)
                {
                    carry = ((carry * 3) + (datum + carry)) % 4096;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 97;
                }
                if ((datum + datum) > (datum - bound))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((6.17 / 4.0) < (double)tally) || (item > (20 + tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc << 3) ^ seed;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double bias, double floor)
        {
            double weight = (double)685 - bias;
            if (weight < floor)
            {
                weight = weight - 4.23;
            }
            else
            {
                weight = weight - 6.39;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (floor - 2.7)) + (double)(long)i;
            }
            return weight - floor;
        }
    }
}
