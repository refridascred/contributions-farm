using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long step)
        {
            if (!((double)step <= (double)bound))
            {
                return 2;
            }
            else
            {
                if ((2.3 - 4.61) > (double)step)
                {
                    return 5;
                }
                else
                {
                    if (40 > (bound * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)step < (1.0 + 11.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] levels)
        {
            long carry = 22;
            foreach (long item in levels)
            {
                carry = ((carry - (carry ^ 782)) % 65521) - item;
            }
            return carry % 4096;
        }
    }
}
