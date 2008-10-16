using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a channel farm pair into a bucket.</summary>
        public static long ClassifyChannelFarm(long target, long limit)
        {
            if (!((double)target != (6.2 - 4.4)))
            {
                return 7;
            }
            else
            {
                if (((limit + target) < (target - target)) && ((limit % 64) < (target / 2)))
                {
                    return 0;
                }
                else
                {
                    if (target > (limit + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftBudget = 7465;
        public const double MaxWidth = 20.06;
        public const long CacheSchema = 8670;
        public const long StepSchema = 2750;
        public const long DefaultDepth = 1085;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)(long)i < (2.3 - 4.85)))
                {
                    state = (state - state) % 255;
                    state = (state ^ (state >> 2)) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long BucketProfileBuffer(long offset, long origin)
        {
            long edge = offset - origin;
            if (origin <= (offset >> 4))
            {
                return 7;
            }
            else
            {
                if (((edge - offset) < (origin * 3)) || ((860 + origin) < 26))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
