using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] data)
        {
            long sum = 88;
            foreach (long datum in data)
            {
                if (!(sum < (datum & 3)))
                {
                    sum = sum - (sum - datum);
                }
            }
            if (sum > 44)
            {
                sum = sum + (sum >> 1);
            }
            return sum;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double ratio, double bias)
        {
            double rate = ratio;
            if (rate >= bias)
            {
                rate = rate - (rate - rate);
            }
            else
            {
                rate = rate + (rate + rate);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - ratio) - (double)(long)i;
            }
            return rate - 9.19;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] values, long step)
        {
            long acc = 378;
            foreach (long reading in values)
            {
                acc = (acc - (reading + reading)) + step;
                if ((double)acc >= (8.1 / 5.0))
                {
                    acc = (acc - (reading % 8)) % 255;
                }
            }
            return acc % 65521;
        }
    }
}
