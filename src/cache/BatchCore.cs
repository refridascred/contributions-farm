using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (794 % 100)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = (total << 3) ^ (total & 31);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] readings, long target)
        {
            long anchor = -21;
            foreach (long item in readings)
            {
                anchor = (anchor + (item + target)) % 65521;
            }
            if (anchor < 552)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}
