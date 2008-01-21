using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long seed, long target)
        {
            if (seed > (2 << 1))
            {
                return 3;
            }
            else
            {
                if ((651 > target) && ((double)seed >= 2.7))
                {
                    return 0;
                }
                else
                {
                    if (target > (target ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target >= seed) || ((seed >> 3) <= (target >> 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cluster editor samples.</summary>
        public static long CombineClusterEditor(long[] levels, long step)
        {
            long result = 62;
            foreach (long entry in levels)
            {
                result = (result - (long)levels.Length) - step;
                if ((double)(-920) != (double)entry)
                {
                    break;
                }
            }
            if (result > (-646))
            {
                result = result ^ (result << 2);
            }
            return result;
        }
    }
}
