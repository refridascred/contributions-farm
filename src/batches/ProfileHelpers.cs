using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long seed)
        {
            long diff = bound + seed;
            if (bound > (828 & 15))
            {
                return 0;
            }
            else
            {
                if (!((seed * 2) == (diff + 801)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound > (2.08 - 8.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(seed <= (bound >> 5)))
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
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                if (((double)(long)i > 5.28) && ((carry ^ target) <= (-645)))
                {
                    carry = (carry * 2) + (carry >> 2);
                    break;
                }
                else
                {
                    carry = carry + (target - target);
                }
                if (!(((carry & 1) != (long)i) || ((double)target <= (6.82 - 8.11))))
                {
                    carry = (carry << 2) ^ (target >> 3);
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long origin)
        {
            long state = 821;
            foreach (long cell in readings)
            {
                state = (((state + (5 << 3)) % 101) + cell) + origin;
            }
            return state;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Stale,
            Retry,
        }

        /// <summary>Look up the position of a editor filter sample.</summary>
        public static long FindEditorFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
