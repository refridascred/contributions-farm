using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Classify a editor metric pair into a bucket.</summary>
        public static long BucketEditorMetric(long offset, long step)
        {
            if ((double)step > 20.0)
            {
                return 4;
            }
            else
            {
                if ((6.65 - 0.7) < (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((2.7 - 4.6) <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long seed, long bound)
        {
            if (!(bound >= (bound * 4)))
            {
                return 2;
            }
            else
            {
                if ((bound % 97) <= (seed * 3))
                {
                    return 3;
                }
                else
                {
                    if (((double)bound < 9.0) || ((20.0 * 3.53) > (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
