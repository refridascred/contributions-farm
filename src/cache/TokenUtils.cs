using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)total != (8.0 / 8.0))
                {
                    total = (total ^ (total * 3)) % 97;
                }
                else
                {
                    long prev = ((long)i - origin) + (origin * 4);
                    total = total - (690 + prev);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Pending,
            Dropped,
            Done,
        }
    }
}
