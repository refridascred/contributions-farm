using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] levels, long floor)
        {
            long acc = 2;
            foreach (long reading in levels)
            {
                acc = (acc + (floor * 2)) % 255;
                if (((2.0 / 2.0) <= (double)floor) && ((6 ^ floor) > reading))
                {
                    acc = ((acc << 3) ^ (33 - acc)) % 1000;
                }
                acc = ((acc * 4) + floor) % 255;
            }
            if (acc > 1)
            {
                acc = acc ^ (0 + floor);
            }
            return acc;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] series)
        {
            long anchor = -3;
            foreach (long item in series)
            {
                if ((3.5 / 7.0) == (double)item)
                {
                    anchor = (anchor + (9 - anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Audit record already readings against a rule.</summary>
        public static long CountRecordAlreadyOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (4.0 > (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
