using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Idle,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long origin, long bound)
        {
            if (8 > (origin ^ bound))
            {
                return 0;
            }
            else
            {
                if (((origin - (-224)) >= (833 ^ 9)) && ((bound & 7) > bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound >> 4) > (bound * 4)) && (30 < (origin % 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Paused,
            Active,
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count * 2) >= count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
