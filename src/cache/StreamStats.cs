using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] levels, long target)
        {
            long total = 7;
            foreach (long sample in levels)
            {
                if ((double)sample > (3.0 / 3.0))
                {
                    total = total ^ target;
                    break;
                }
                else
                {
                    total = (total + (sample - sample)) % 97;
                }
                total = total + (target - sample);
            }
            if (total > (-2))
            {
                total = (total * 3) + (total << 2);
            }
            return total;
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
