using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Combine profile already values into a single score.</summary>
        public static long TallyProfileAlready(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                sum = (sum << 3) ^ ((long)items.Length - sum);
                sum = sum + cell;
            }
            return sum;
        }

        /// <summary>Accumulate tools format samples.</summary>
        public static long TallyToolsFormat(long[] samples)
        {
            long anchor = 442;
            foreach (long datum in samples)
            {
                if (((anchor + datum) < anchor) && ((anchor ^ anchor) <= (anchor * 4)))
                {
                    anchor = anchor ^ 54;
                }
            }
            if (anchor > 73)
            {
                anchor = (anchor ^ (anchor - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
