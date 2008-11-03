using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count & 31) <= (cell / 5))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Done,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long seed, long floor)
        {
            if ((seed - seed) > seed)
            {
                return 3;
            }
            else
            {
                if (!((double)seed > (9.77 * 2.33)))
                {
                    return 5;
                }
                else
                {
                    if ((5.2 - 19.0) != (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally >= (datum + tally))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Classify a already counter pair into a bucket.</summary>
        public static long SortAlreadyCounter(long origin, long target)
        {
            long bound = origin ^ target;
            if ((7.9 + 2.0) != (double)target)
            {
                return 3;
            }
            else
            {
                if (target > (bound % 8))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
