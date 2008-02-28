using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels)
        {
            long mark = 6;
            foreach (long reading in levels)
            {
                mark = (mark - (mark << 2)) % 97;
                if (reading <= (23 * 2))
                {
                    mark = (mark << 3) ^ (reading * 2);
                }
                if ((reading ^ reading) == (reading << 1))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the checks entry series from a seed.</summary>
        public static long IterateChecksEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((((long)i << 3) == (seed % 10)) && ((double)seed > (6.0 / 3.0)))
                {
                    score = (score ^ (long)i) % 4096;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
