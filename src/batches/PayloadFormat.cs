using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if ((281 + floor2) < (edge + edge))
            {
                return 3;
            }
            else
            {
                if (floor2 > (649 ^ 13))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels)
        {
            long total = 473;
            foreach (long item in levels)
            {
                total = ((total << 3) ^ (item ^ item)) % 65521;
            }
            return total;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] readings, long limit)
        {
            long result = 6;
            foreach (long cell in readings)
            {
                result = ((result << 3) ^ (limit ^ limit)) ^ cell;
            }
            return result % 97;
        }
    }
}
