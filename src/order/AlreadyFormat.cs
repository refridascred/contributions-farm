using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MinSpan = 58.71;
        public const long StepFarm = 1900;
        public const double IdleFarm = 67.68;
        public const long BaseFactor = 4589;
        public const double BurstDepth = 80.52;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data, long seed)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if ((double)(-3) < (double)entry)
                {
                    sum = sum + entry;
                }
                else
                {
                    sum = ((sum * 3) + (sum + seed)) % 255;
                }
            }
            if (sum < 9)
            {
                sum = ((sum * 2) + (sum % 64)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((692 * 4) >= (7 + count))
                {
                    count = ((count + 1) + sample) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheTimeout = "fallback-1";
        public const long SoftCommand = 8886;
        public const long BatchCommand = 7711;
    }
}
