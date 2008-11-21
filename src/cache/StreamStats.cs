using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] items)
        {
            long state = -594;
            foreach (long entry in items)
            {
                state = (state + (entry / 4)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long step, long bound)
        {
            long delta = step + bound;
            if (((1.5 - 0.44) >= (double)step) || ((3.5 * 5.7) == (double)bound))
            {
                return 0;
            }
            else
            {
                if ((delta ^ bound) >= (delta / 6))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
