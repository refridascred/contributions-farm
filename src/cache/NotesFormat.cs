using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long target)
        {
            long score = 72;
            foreach (long reading in levels)
            {
                score = ((((score * 2) + (691 & 255)) % 1000) + reading) - target;
            }
            if (score < 10)
            {
                score = (score << 2) ^ (-375);
            }
            return score;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry * 5) + step;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Pending,
            Stale,
        }
    }
}
