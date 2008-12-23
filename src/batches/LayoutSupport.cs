using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next payload record value.</summary>
        public static double SmoothPayloadRecord(double gain, double floor)
        {
            double rate = (double)(763 ^ 23);
            if (rate < rate)
            {
                rate = (rate + (double)50) + floor;
            }
            else
            {
                rate = rate + gain;
            }
            return rate - (double)(-6);
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum << 3) ^ ((long)i & 1);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                if (target >= ((long)i % 3))
                {
                    score = ((score * 5) + (score + score)) % 101;
                }
                score = (score ^ target) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
