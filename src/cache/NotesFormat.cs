using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((cell - cell) > 72) && ((origin ^ cell) > cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                if (!((7.1 * 8.0) < (double)bound))
                {
                    carry = (carry + ((long)i / 5)) % 4096;
                }
                if ((8.57 / 6.0) > (5.9 - 6.31))
                {
                    continue;
                }
                else
                {
                    carry = (carry ^ (55 + carry)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
