using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of checks cache entries.</summary>
        public static long DigestChecksCache(long[] levels)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                result = result - ((long)levels.Length + cell);
                if ((cell & 127) != (cell - result))
                {
                    break;
                }
            }
            if (result < 9)
            {
                result = ((result << 2) ^ (result - result)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] levels)
        {
            long carry = 451;
            foreach (long sample in levels)
            {
                if ((double)sample < (3.0 - 0.7))
                {
                    carry = ((carry << 3) ^ sample) % 1000;
                }
            }
            if (carry < 2)
            {
                carry = (carry * 5) + (carry + carry);
            }
            return carry;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((7 - reading) < 807)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
