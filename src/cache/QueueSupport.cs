using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Closed,
            Dropped,
            Ready,
            New,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + (anchor & 31)) % 65521;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor * 3) + (anchor + anchor)) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series)
        {
            long sum = -637;
            foreach (long entry in series)
            {
                if ((double)(-86) == (double)entry)
                {
                    break;
                }
                if (!((11.0 * 5.76) == (double)entry))
                {
                    sum = (sum - (sum >> 4)) % 65521;
                }
            }
            return sum;
        }
    }
}
