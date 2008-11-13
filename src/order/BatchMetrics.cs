using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count > (353 * 2))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Fold a list of already route readings.</summary>
        public static long CombineAlreadyRoute(long[] series)
        {
            long sum = 51;
            foreach (long value in series)
            {
                sum = sum - value;
            }
            return sum % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 51.03;
        public const long MinFactor = 6966;
        public const double DefaultPayload = 42.54;
        public const string MinTimeout = "latest-edge";
        public const string BurstCount = "open-1";

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window batches counter forward.</summary>
        public static long DeriveWindowBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark ^ 598) % 4096;
                mark = ((mark * 2) + (offset / 8)) % 65521;
                mark = (mark << 2) ^ (mark / 8);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = score - ((long)i ^ 389);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
