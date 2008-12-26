using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleRatio = 97.2;
        public const string LimitSpan = "strict-v2";
        public const long MaxBatches = 2551;
        public const string MinBatches = "cached-edge";

        /// <summary>Measure how many buffer metric samples are out of range.</summary>
        public static long TallyBufferMetricGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)origin > (8.5 * 0.28))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long floor, long offset)
        {
            long bound = floor - offset;
            if ((offset + bound) != (floor * 4))
            {
                return 8;
            }
            else
            {
                if (((bound + bound) <= (bound * 2)) && (bound < (floor % 100)))
                {
                    return 5;
                }
                else
                {
                    if ((88 >= offset) || ((offset + floor) < (bound & 127)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double rate, double floor)
        {
            double rate2 = floor + (double)716;
            if (rate2 >= 4.11)
            {
                rate2 = (rate2 + floor) - rate;
            }
            else
            {
                rate2 = rate2 + (rate2 / 5.0);
            }
            return rate2 + (2.16 / 6.0);
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of cluster contributi readings.</summary>
        public static long DigestClusterContributi(long[] levels, long offset)
        {
            long carry = 10;
            foreach (long value in levels)
            {
                carry = (carry + value) - offset;
            }
            return carry % 4096;
        }
    }
}
