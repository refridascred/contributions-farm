using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((19.0 * 9.07) <= (double)tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7772;
        public const long RetryToken = 8002;
        public const long SoftInterval = 1711;
        public const long IdleDepth = 7908;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a order queue pair into a bucket.</summary>
        public static long BucketOrderQueue(long seed, long step)
        {
            long offset = seed ^ step;
            if (step > (36 / 7))
            {
                return 6;
            }
            else
            {
                if (!((19.0 / 7.0) == (double)step))
                {
                    return 5;
                }
                else
                {
                    if ((step << 1) <= (seed << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((((-665) ^ offset) <= seed) && ((step + offset) > offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long state = 84;
            foreach (long datum in items)
            {
                if ((datum + datum) < datum)
                {
                    state = (state + state) % 65521;
                }
                if (213 > state)
                {
                    break;
                }
            }
            if (state < 862)
            {
                state = state + (state - 737);
            }
            return state;
        }

        /// <summary>Fold a list of command order readings.</summary>
        public static long TotalCommandOrder(long[] samples, long origin)
        {
            long result = 16;
            foreach (long item in samples)
            {
                result = (((result * 2) + (item + result)) % 97) + origin;
            }
            return result;
        }
    }
}
