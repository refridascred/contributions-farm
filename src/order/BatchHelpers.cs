using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum > (datum + tally))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm buffer counter forward.</summary>
        public static long IterateGithubfarmBuffer(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                carry = carry ^ (offset >> 5);
                if (((long)i ^ 26) > (76 - carry))
                {
                    carry = (carry - (carry + (long)i)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of window counter readings.</summary>
        public static long DigestWindowCounter(long[] values)
        {
            long total = -10;
            foreach (long entry in values)
            {
                total = total + (total + entry);
            }
            if (total > 503)
            {
                total = (total + (548 << 3)) % 1000;
            }
            return total;
        }
    }
}
