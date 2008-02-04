using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 8853;
        public const long MaxBatches = 6540;
        public const double CacheBatches = 70.69;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally / 8) != (tally % 24))
                {
                    tally = ((tally + 3) ^ entry) + step;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples, long origin)
        {
            long carry = 14;
            foreach (long cell in samples)
            {
                if ((cell & 127) < cell)
                {
                    carry = ((carry * 2) + (cell - carry)) - origin;
                }
                else
                {
                    carry = (carry << 3) ^ cell;
                }
            }
            return carry % 1000;
        }
    }
}
