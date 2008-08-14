using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long carry = 270;
            foreach (long value in readings)
            {
                carry = (carry << 3) ^ (carry & 1);
                if ((9.8 * 6.72) <= (double)carry)
                {
                    carry = ((carry << 3) ^ (82 + value)) % 4096;
                }
                else
                {
                    carry = ((carry << 2) ^ (value >> 5)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftSpan = 2158;
        public const long WindowProfile = 4415;
        public const long MaxProfile = 4207;
        public const long SoftProfile = 9676;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long limit2)
        {
            if ((double)limit2 < (double)limit)
            {
                return 8;
            }
            else
            {
                if (limit2 > (973 % 97))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally + 3) < (cell << 3))
                {
                    tally = (tally + 3) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitWidth = "stable-1";
        public const string MaxNotes = "alpha-edge";
        public const long MaxFactor = 8762;
    }
}
