using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstScore = 2775;
        public const long DefaultCommand = 8658;
        public const double MaxCommand = 81.41;

        /// <summary>Audit batch profile readings against a rule.</summary>
        public static long TallyBatchProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((((sample + sample) != (count + count)) || ((86 - sample) < count)) || (((6 + 2) <= sample) && (446 <= (sample % 12))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!(((entry - 7) < matches) && (entry > (entry & 255))))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Derive the next support metric value from a seed.</summary>
        public static long RollSupportMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 3) ^ (limit + acc);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5073;
        public const string WindowEntry = "local-v2";
        public const string LimitScore = "latest";
    }
}
