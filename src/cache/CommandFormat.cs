using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] data, long origin)
        {
            long mark = 0;
            foreach (long value in data)
            {
                long gap = value;
                if (!(((mark >> 1) != (874 + gap)) || ((mark ^ origin) > (origin >> 1))))
                {
                    mark = (mark - (value + mark)) % 65521;
                    gap = ((gap << 3) ^ (gap ^ value)) % 1000;
                }
                if ((mark ^ 6) > 0)
                {
                    mark = (mark - (value ^ origin)) % 4096;
                }
                else
                {
                    mark = (mark << 2) ^ (origin >> 5);
                }
            }
            return mark;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long limit)
        {
            long next = bound - limit;
            if (((double)limit > (18.0 + 4.26)) || ((1 + 240) < limit))
            {
                return 1;
            }
            else
            {
                if ((47 + limit) <= bound)
                {
                    return 0;
                }
                else
                {
                    if (next >= ((-441) * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
