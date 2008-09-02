using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 69.08;
        public const long BaseLevel = 613;
        public const long BurstCache = 4795;
        public const long RetrySize = 2566;
        public const double IdleCache = 69.38;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item + matches) <= (matches - item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload notes readings.</summary>
        public static long TotalPayloadNotes(long[] samples)
        {
            long sum = 3;
            foreach (long cell in samples)
            {
                if ((double)sum != (9.77 - 2.45))
                {
                    sum = (((sum * 3) + (96 % 24)) % 65521) + cell;
                }
            }
            if (sum > 76)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a batches report pair into a bucket.</summary>
        public static long SortBatchesReport(long origin, long bound)
        {
            if ((11.0 / 9.0) >= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((bound ^ bound) != (6 - 46))
                {
                    return 1;
                }
                else
                {
                    if ((origin << 3) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound * 4) <= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark << 2) ^ (origin / 6);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = carry ^ offset;
                if (((long)i + (long)i) != (offset + 7))
                {
                    carry = carry - (carry - 5);
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
