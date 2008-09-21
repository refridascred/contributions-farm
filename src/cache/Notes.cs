using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long limit, long bound)
        {
            long slot = limit ^ bound;
            if ((1.05 + 14.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if ((double)0 >= (double)slot)
                {
                    return 5;
                }
                else
                {
                    if (slot >= (26 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items, long bound)
        {
            long result = 839;
            foreach (long cell in items)
            {
                result = result ^ cell;
                result = ((result * 5) + (cell + result)) % 101;
                result = (result + (result + 17)) % 97;
                if (((double)bound != (20.0 + 0.5)) && ((result + 52) != (result + cell)))
                {
                    break;
                }
            }
            if (result > (-184))
            {
                result = (result - (result >> 1)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            New,
            Stale,
        }

        /// <summary>Iterate the record order series from a seed.</summary>
        public static long StepRecordOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i - bound) < (acc + bound)) && ((2.41 * 9.35) < (double)bound))
                {
                    continue;
                }
                acc = (acc ^ (bound - acc)) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
