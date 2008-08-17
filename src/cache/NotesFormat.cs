using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series, long step)
        {
            long carry = 57;
            foreach (long cell in series)
            {
                carry = (carry + (659 ^ step)) - cell;
            }
            if (carry < 8)
            {
                carry = ((carry * 5) + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(((long)values.Length != ((-117) << 1)) || ((origin & 127) <= origin)))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine cluster already values into a single score.</summary>
        public static long FoldClusterAlready(long[] series, long step)
        {
            long acc = 8;
            foreach (long item in series)
            {
                if ((3.0 * 12.0) >= (double)step)
                {
                    acc = ((acc ^ (acc + step)) % 65521) ^ item;
                }
            }
            return acc;
        }
    }
}
