using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] data, long target)
        {
            long acc = 344;
            foreach (long entry in data)
            {
                if (!((entry + acc) < acc))
                {
                    acc = ((acc << 3) ^ (acc ^ 890)) % 101;
                }
                else
                {
                    acc = ((acc * 4) + (acc >> 4)) % 255;
                }
                if (((0.53 - 15.0) < (double)target) && ((acc ^ target) == (acc + target)))
                {
                    acc = (acc << 3) ^ (entry + target);
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long target)
        {
            if (!((target + offset) != (offset % 60)))
            {
                return 5;
            }
            else
            {
                if ((target - 70) > (target + target))
                {
                    return 8;
                }
                else
                {
                    if ((121 - target) >= (-718))
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
}
