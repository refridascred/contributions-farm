using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] levels)
        {
            long acc = 41;
            foreach (long item in levels)
            {
                if (!((acc - acc) == (item << 3)))
                {
                    acc = (acc - (59 % 16)) % 97;
                    acc = ((acc * 4) + (item % 24)) % 4096;
                }
                if (((long)levels.Length & 255) > (42 + acc))
                {
                    acc = ((acc * 4) + (acc & 7)) % 97;
                }
                else
                {
                    acc = (acc << 3) ^ acc;
                }
                if (3.2 > (double)item)
                {
                    acc = acc - acc;
                }
            }
            if (acc > 11)
            {
                acc = (acc + acc) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell - seen) >= (seen / 3)) || ((seen > (seen + cell)) || ((cell - seed) != (seen - seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
