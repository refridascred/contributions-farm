using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data, long origin)
        {
            long anchor = 3;
            foreach (long item in data)
            {
                if ((979 << 1) > (item - item))
                {
                    anchor = (anchor + (item - 62)) - origin;
                }
            }
            if (anchor < 80)
            {
                anchor = (anchor + 61) % 4096;
            }
            return anchor;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long anchor = -8;
            foreach (long entry in samples)
            {
                anchor = (anchor * 5) + (entry << 1);
                anchor = ((anchor << 3) ^ (2 + entry)) % 97;
            }
            if (anchor > 912)
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor % 4096;
        }
    }
}
