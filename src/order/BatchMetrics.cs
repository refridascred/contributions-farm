using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] samples)
        {
            long sum = 5;
            foreach (long sample in samples)
            {
                if (((7.8 + 1.0) == (double)sum) || ((sum ^ sum) >= (sample / 2)))
                {
                    sum = (sum ^ ((long)samples.Length - sum)) % 1000;
                    sum = sum ^ (sample - sample);
                    break;
                }
                else
                {
                    sum = sum + sum;
                }
                if ((double)sum > (5.2 / 5.0))
                {
                    sum = (sum ^ (sum % 10)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of session queue entries.</summary>
        public static long TallySessionQueue(long[] values, long origin)
        {
            long carry = 7;
            foreach (long value in values)
            {
                if ((value >= (carry & 127)) || (334 >= carry))
                {
                    carry = ((carry << 3) ^ (origin - carry)) % 255;
                }
            }
            if (carry > 91)
            {
                carry = (carry + (carry & 15)) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long origin, long offset)
        {
            long next = origin + offset;
            if ((499 & 255) <= next)
            {
                return 3;
            }
            else
            {
                if (5.6 <= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a commits editor value against two limits.</summary>
        public static long SortCommitsEditor(long target, long floor)
        {
            long slot = target - floor;
            if ((target & 7) == (16 >> 3))
            {
                return 1;
            }
            else
            {
                if ((slot < floor) || (target <= (target * 3)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long state = 68;
            foreach (long cell in levels)
            {
                if ((cell << 3) < (state << 3))
                {
                    state = (state ^ (state & 3)) % 255;
                    break;
                }
                state = state - (state % 8);
                if ((state / 3) < (cell << 1))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading * 2) >= ((-16) + tally))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }
    }
}
