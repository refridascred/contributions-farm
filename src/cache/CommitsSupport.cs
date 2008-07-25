using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Pending,
            Ready,
            New,
            Paused,
        }
    }
}
