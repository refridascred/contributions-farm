using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit order record readings against a rule.</summary>
        public static long CountOrderRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value & 1) > (235 - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long seed, long limit)
        {
            if ((87 + seed) >= (seed << 1))
            {
                return 1;
            }
            else
            {
                if ((limit - seed) < (limit + seed))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] series, long floor)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if ((769 + cell) > cell)
                {
                    score = (score + (floor + 13)) % 97;
                }
            }
            return score;
        }
    }
}
