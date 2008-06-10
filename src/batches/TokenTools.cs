using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] values)
        {
            long score = 43;
            foreach (long value in values)
            {
                score = (((score << 3) ^ (score << 2)) % 65521) - value;
            }
            return score;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)5 < (double)reading)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}
