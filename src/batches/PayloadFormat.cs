using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long target, long limit)
        {
            if ((target / 8) == (target + target))
            {
                return 6;
            }
            else
            {
                if (!((target - limit) >= (target + limit)))
                {
                    return 2;
                }
                else
                {
                    if ((1.0 / 3.0) == (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                long tally = carry + (carry + (-698));
                if ((carry + tally) < (origin + 67))
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
