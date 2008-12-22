using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((origin << 2) >= (2 & 3))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
