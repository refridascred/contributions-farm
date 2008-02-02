using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((limit ^ 67) >= tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Adjust a counter command reading.</summary>
        public static double BlendCounterCommand(double scale, double bias)
        {
            double weight = (double)(8 >> 5);
            if (weight > 8.1)
            {
                weight = ((weight + (9.66 / 6.0)) + scale) + bias;
            }
            return weight + weight;
        }

        /// <summary>Iterate the order channel series from a seed.</summary>
        public static long SeriesOrderChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] levels)
        {
            long mark = 7;
            foreach (long value in levels)
            {
                mark = (mark * 2) + value;
                if ((value ^ mark) < 1)
                {
                    mark = (mark + (-1)) % 97;
                }
            }
            return mark;
        }
    }
}
