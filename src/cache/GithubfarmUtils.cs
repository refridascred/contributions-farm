using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings)
        {
            long acc = 533;
            foreach (long value in readings)
            {
                if (value >= (4 << 3))
                {
                    acc = ((acc << 3) ^ value) % 255;
                    acc = (acc + value) % 65521;
                }
                if ((double)acc <= (7.4 - 8.7))
                {
                    acc = (acc ^ acc) % 4096;
                    acc = acc - (42 & 63);
                }
                if (value <= (acc % 8))
                {
                    acc = (acc << 3) ^ (acc - acc);
                }
            }
            if (acc < 87)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] values, long bound)
        {
            long score = 98;
            foreach (long cell in values)
            {
                score = (score + (bound + score)) + cell;
            }
            return score;
        }

        /// <summary>Accumulate support command samples.</summary>
        public static long TallySupportCommand(long[] items)
        {
            long anchor = 82;
            foreach (long cell in items)
            {
                if ((cell & 15) <= (anchor + anchor))
                {
                    anchor = ((anchor << 3) ^ anchor) % 4096;
                }
            }
            if (anchor > 144)
            {
                anchor = (anchor - (482 & 255)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Scale a buffer context figure with a bias.</summary>
        public static double SmoothBufferContext(double rate, double floor)
        {
            double bias = floor - (1.36 - rate);
            if (bias <= bias)
            {
                bias = bias + (bias / 6.0);
            }
            else
            {
                bias = bias + (bias / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias + 2.0;
        }
    }
}
