using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long bound)
        {
            long lane = target + bound;
            if ((target > (1 - lane)) || ((double)bound <= (3.5 / 3.0)))
            {
                return 5;
            }
            else
            {
                if (!((bound >> 1) != (bound << 2)))
                {
                    return 6;
                }
                else
                {
                    if ((5.0 - 18.0) < (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target + lane) < (bound / 9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Draft,
            Active,
            Paused,
            New,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Dropped,
            Pending,
            New,
        }
    }
}
