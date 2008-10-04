using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count - 120) >= count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
