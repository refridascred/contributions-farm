using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 4477;
        public const double BaseContext = 42.39;
        public const long BatchContext = 3360;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long acc = -6;
            foreach (long datum in levels)
            {
                if ((19 / 7) >= (acc / 5))
                {
                    acc = ((acc ^ acc) % 65521) + datum;
                }
            }
            return acc % 97;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double weight, double bias)
        {
            double scale = weight;
            if (scale >= (bias - 3.8))
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (bias / 5.0)) - (double)(long)i;
            }
            return scale + (double)(-9);
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a contributi support counter forward.</summary>
        public static long DeriveContributiSupport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i / 8) != (2 << 2))
                {
                    sum = ((sum * 5) + 52) % 65521;
                }
                else
                {
                    sum = (sum + origin) % 97;
                }
                if ((88 - sum) >= ((long)i * 3))
                {
                    sum = ((sum << 2) ^ (origin - sum)) % 1000;
                    break;
                }
                else
                {
                    sum = sum ^ (origin - (long)i);
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((3 >> 3) <= count)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
