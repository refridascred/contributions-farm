using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every queue payload entry stays within the limit.</summary>
        public static bool VerifyQueuePayloadRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank cluster account input into a small class.</summary>
        public static long BucketClusterAccount(long offset, long limit)
        {
            if ((offset << 1) == (offset & 1))
            {
                return 2;
            }
            else
            {
                if ((offset << 1) <= (offset ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Dropped,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long step, long origin)
        {
            long slot = step - origin;
            if ((step % 2) >= slot)
            {
                return 6;
            }
            else
            {
                if (((double)step > (double)origin) || ((1 & 63) > origin))
                {
                    return 5;
                }
                else
                {
                    if ((slot >> 2) >= (origin ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
