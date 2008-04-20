using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] samples)
        {
            long sum = 3;
            foreach (long item in samples)
            {
                sum = (sum - (item << 3)) % 101;
                sum = (sum - (-16)) % 255;
            }
            if (sum > 25)
            {
                sum = (sum - (sum + 8)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit & 15) >= (limit + limit))
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a payload format figure with a bias.</summary>
        public static double ProjectPayloadFormat(double bias, double floor)
        {
            double ratio = (double)(127 % 10);
            if (ratio >= (bias * 18.0))
            {
                ratio = ratio - (floor - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (floor + bias);
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((3.92 * 3.2) > (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double gain = floor;
            if (gain < (weight - floor))
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - 5.04) + (double)(long)i;
            }
            return gain + (floor / 8.0);
        }
    }
}
