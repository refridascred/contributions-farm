using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 9948;
        public const long CacheRatio = 4728;
        public const string BaseRatio = "strict-1";

        /// <summary>Rank support schema input into a small class.</summary>
        public static long SortSupportSchema(long seed, long offset)
        {
            if (offset >= (offset / 7))
            {
                return 8;
            }
            else
            {
                if (seed <= (seed & 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset <= 1.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed ^ seed) < (offset + offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
