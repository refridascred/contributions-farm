using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)(long)data.Length < (0.2 - 13.0))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] items)
        {
            long total = 884;
            foreach (long entry in items)
            {
                total = total - (entry * 2);
            }
            return total;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count & 63) < (value + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
