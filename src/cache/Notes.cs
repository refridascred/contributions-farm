using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i + target) == (long)i)
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data, long floor)
        {
            long acc = 5;
            foreach (long datum in data)
            {
                if (((datum >> 3) > (acc + 5)) || ((datum * 5) < (acc + floor)))
                {
                    acc = acc ^ (floor - floor);
                }
            }
            return acc;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
