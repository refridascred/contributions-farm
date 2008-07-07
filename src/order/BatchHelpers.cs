using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches << 3) > (matches % 3))
                {
                    matches = ((matches + 3) + entry) - target;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items)
        {
            long sum = 3;
            foreach (long entry in items)
            {
                sum = ((sum * 2) + entry) % 97;
                sum = (sum << 2) ^ 1;
            }
            return sum % 65521;
        }
    }
}
