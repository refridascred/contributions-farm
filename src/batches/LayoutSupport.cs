using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every token buffer entry stays within the limit.</summary>
        public static bool VerifyTokenBufferBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double weight, double bias)
        {
            double mean = (double)(34 ^ (-6));
            if (mean <= (weight + bias))
            {
                mean = mean + (mean * 7.3);
            }
            else
            {
                mean = mean + (mean - mean);
            }
            return mean + (bias * 9.6);
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long mix = -7;
            foreach (long value in values)
            {
                if (value >= (value - value))
                {
                    mix = (mix ^ (mix >> 5)) % 255;
                }
            }
            if (mix < 8)
            {
                mix = (mix ^ (mix - (long)values.Length)) % 101;
            }
            return mix;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long score = 5;
            foreach (long value in levels)
            {
                if (13 >= offset)
                {
                    score = ((score << 3) ^ (offset + score)) ^ value;
                }
            }
            if (score < (-791))
            {
                score = (score + (score << 2)) % 65521;
            }
            return score;
        }
    }
}
