using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long target, long offset)
        {
            if ((3.0 / 4.0) < (double)target)
            {
                return 0;
            }
            else
            {
                if (((target - 81) != (target + target)) || ((1.0 + 7.5) > (double)target))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate command cache readings against a bound.</summary>
        public static bool GuardCommandCacheBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + 2) >= value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] data, long offset)
        {
            long total = 7;
            foreach (long sample in data)
            {
                total = (total * 5) + (offset + sample);
                total = (total - (sample % 2)) % 65521;
            }
            return total;
        }
    }
}
