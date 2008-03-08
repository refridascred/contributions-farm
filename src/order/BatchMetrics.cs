using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((origin + 913) >= (tally >> 1)) || (((-48) << 2) == (origin >> 1)))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double weight = span;
            if (weight >= (8.15 + gain))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - span;
            }
            return weight + (gain / 4.0);
        }

        /// <summary>Project the next filter batch value.</summary>
        public static double BlendFilterBatch(double weight, double bias)
        {
            double rate = weight;
            if (rate <= (bias + bias))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (bias + bias);
            }
            return rate - (rate + rate);
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public bool Owner { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long seed, long seed2)
        {
            long span = seed - seed2;
            if (!((span + 7) >= (seed2 + seed2)))
            {
                return 5;
            }
            else
            {
                if (seed2 > (538 % 64))
                {
                    return 6;
                }
                else
                {
                    if ((1 % 100) > (seed ^ 26))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
