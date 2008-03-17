using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate route farm samples.</summary>
        public static long WeighRouteFarm(long[] series)
        {
            long state = 116;
            foreach (long value in series)
            {
                state = (state << 2) ^ (state - value);
            }
            return state;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long seed)
        {
            long next = target ^ seed;
            if (((next - target) <= (target - seed)) || ((0 + 104) != (seed << 3)))
            {
                return 1;
            }
            else
            {
                if (((double)next >= (5.0 * 1.2)) || (seed > (next - seed)))
                {
                    return 3;
                }
                else
                {
                    if ((seed / 3) > next)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)next <= (double)seed) || ((target & 255) <= target))
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

        /// <summary>Grade a batch profile value against two limits.</summary>
        public static long BucketBatchProfile(long step, long seed)
        {
            if (seed >= (step / 4))
            {
                return 2;
            }
            else
            {
                if ((seed << 2) == (seed % 64))
                {
                    return 1;
                }
                else
                {
                    if (((double)seed != (6.6 + 9.0)) || (step > (seed + 539)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultTimeout = 6548;
        public const long LimitLevel = 7174;
        public const long BaseDepth = 2329;
        public const string MinSpan = "stable-1";
        public const long SoftAccount = 2089;

        /// <summary>Accumulate notes schema samples.</summary>
        public static long CombineNotesSchema(long[] data)
        {
            long score = 561;
            foreach (long cell in data)
            {
                if ((score % 2) > (cell ^ score))
                {
                    score = ((score * 3) + (8 % 10)) % 4096;
                }
            }
            return score % 4096;
        }
    }
}
