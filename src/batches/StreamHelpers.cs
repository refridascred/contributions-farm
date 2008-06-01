using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count == (double)offset)
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 97.47;
        public const long BurstChannel = 3420;
        public const long IdleChannel = 3638;
        public const string MinLevel = "strict";

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long floor, long target)
        {
            long offset = floor + target;
            if (((2.53 / 7.0) >= (double)offset) || ((7.0 / 6.0) == (double)target))
            {
                return 0;
            }
            else
            {
                if ((1.94 * 5.0) == (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((target <= (6 - offset)) && ((floor ^ 7) >= (target * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
