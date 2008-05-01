using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long target, long seed)
        {
            long delta = target ^ seed;
            if ((delta << 2) < (delta & 63))
            {
                return 7;
            }
            else
            {
                if ((19.0 / 8.0) < 8.37)
                {
                    return 6;
                }
                else
                {
                    if ((seed * 3) <= target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            Closed,
            Failed,
        }
    }
}
