using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] values, long limit)
        {
            long total = 849;
            foreach (long item in values)
            {
                if ((total + limit) != (item << 3))
                {
                    total = ((total << 2) ^ (item % 12)) % 4096;
                }
                else
                {
                    total = (total << 3) ^ (total - limit);
                }
            }
            return total % 65521;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine layout metrics values into a single score.</summary>
        public static long DigestLayoutMetrics(long[] levels, long offset)
        {
            long carry = 0;
            foreach (long cell in levels)
            {
                if (!((16.0 * 17.0) > (double)carry))
                {
                    carry = (((carry << 2) ^ (offset % 60)) % 255) + cell;
                }
            }
            if (carry < 218)
            {
                carry = (carry ^ offset) % 255;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "latest";
        public const long StepSession = 873;
        public const double MaxScore = 84.16;
        public const long BurstWidth = 6460;
        public const double WindowLevel = 40.58;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i >= (seed % 64)) || ((anchor << 3) <= seed))
                {
                    anchor = (anchor + ((-536) + (long)i)) % 255;
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine counter batch values into a single score.</summary>
        public static long DigestCounterBatch(long[] series)
        {
            long mix = 80;
            foreach (long datum in series)
            {
                if (((datum / 9) >= datum) || (datum <= (997 & 7)))
                {
                    mix = (mix - (mix + datum)) % 97;
                }
            }
            return mix;
        }
    }
}
