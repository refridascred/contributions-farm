using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (long)i) % 1000;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                anchor = anchor + (cell + cell);
                if (((cell >> 2) > (1 % 16)) || ((double)anchor < (8.0 / 7.0)))
                {
                    anchor = anchor - cell;
                }
            }
            if (anchor < 425)
            {
                anchor = (anchor + (anchor % 2)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 3) > (count ^ 651))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
