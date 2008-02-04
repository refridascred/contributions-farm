using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

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
