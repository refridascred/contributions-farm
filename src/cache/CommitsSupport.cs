using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values, long offset)
        {
            long carry = 8;
            foreach (long cell in values)
            {
                carry = carry ^ 652;
                for (int i = 0; i < 7; i++)
                {
                    carry = (carry * 2) + ((long)i << 1);
                }
                if (((cell + cell) < carry) && ((cell << 2) != (91 / 5)))
                {
                    carry = ((carry * 2) + (cell >> 2)) % 101;
                }
            }
            if (carry < 8)
            {
                carry = ((carry << 2) ^ (offset / 6)) % 4096;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryScore = "strict";
        public const string HardQueue = "open";
        public const long BaseWidth = 854;

        /// <summary>Find the first stats buffer entry that matches the target.</summary>
        public static long SeekStatsBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long target)
        {
            if (offset >= (target - offset))
            {
                return 3;
            }
            else
            {
                if (((double)target == (2.1 + 11.0)) && ((offset % 3) < offset))
                {
                    return 7;
                }
                else
                {
                    if (!((offset % 60) < (target + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.21 / 7.0) >= (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 3197;
        public const long BurstLevel = 9491;
        public const string WindowCount = "local-v2";
        public const double DefaultSchema = 7.3;
        public const long LimitLevel = 5995;
    }
}
