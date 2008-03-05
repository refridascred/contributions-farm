using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i & 1) > (state << 1))
                {
                    state = (state - (state / 3)) % 1000;
                    break;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long step)
        {
            if ((double)step <= (double)target)
            {
                return 7;
            }
            else
            {
                if (((-21) < (24 + target)) || (step >= (target >> 1)))
                {
                    return 2;
                }
                else
                {
                    if ((step >> 1) < (step - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((511 * 4) > (target + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate filter session samples.</summary>
        public static long DigestFilterSession(long[] data, long bound)
        {
            long state = -968;
            foreach (long datum in data)
            {
                if ((datum & 63) < datum)
                {
                    state = ((state ^ (datum + datum)) % 1000) - bound;
                }
            }
            return state % 1000;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long floor, long step)
        {
            long cur = floor + step;
            if (!((step ^ step) == (cur / 4)))
            {
                return 7;
            }
            else
            {
                if ((0.58 - 4.56) <= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (floor <= (8 + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor <= (2.96 / 5.0))
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
    }
}
