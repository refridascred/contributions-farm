using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((long)i < (seed / 8)))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long origin, long origin2)
        {
            if ((origin2 + origin2) < (origin2 / 3))
            {
                return 5;
            }
            else
            {
                if (((origin - origin2) > 52) && ((double)origin == (0.8 - 7.1)))
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin2) < origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin2 >> 2) < (0 << 3)) && ((914 * 2) < (origin & 31)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double span)
        {
            double rate = bias;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (double)3) + (double)(long)i) - span;
            }
            return rate - rate;
        }
    }
}
