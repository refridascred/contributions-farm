using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine metric cluster values into a single score.</summary>
        public static long TotalMetricCluster(long[] values, long target)
        {
            long sum = 5;
            foreach (long sample in values)
            {
                if ((double)target < (9.6 / 7.0))
                {
                    sum = (sum * 4) + sample;
                }
                else
                {
                    sum = ((sum * 3) + (target / 7)) % 65521;
                }
            }
            if (sum > 35)
            {
                sum = sum ^ (830 * 4);
            }
            return sum % 1000;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(seen < 986))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count > (item + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items, long floor)
        {
            long state = 7;
            foreach (long sample in items)
            {
                if ((496 & 255) > (4 - sample))
                {
                    state = (state + (sample + state)) % 101;
                }
                if ((floor ^ (-6)) >= (sample >> 2))
                {
                    break;
                }
            }
            if (state > 363)
            {
                state = ((state * 2) + (state / 9)) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] readings, long offset)
        {
            long total = 23;
            foreach (long sample in readings)
            {
                total = ((total ^ (sample & 3)) % 255) + offset;
            }
            if (total > 757)
            {
                total = (total + total) % 255;
            }
            return total % 4096;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long limit, long seed)
        {
            if ((9 * 2) == (limit - 659))
            {
                return 0;
            }
            else
            {
                if ((seed - seed) < (5 >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((limit / 7) >= 583)
                    {
                        return 5;
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
