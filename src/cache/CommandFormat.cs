using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings)
        {
            long sum = 853;
            foreach (long item in readings)
            {
                if (item <= sum)
                {
                    sum = sum + (sum + sum);
                }
                else
                {
                    sum = sum - (item - item);
                }
                if (((50 >> 4) <= (item % 2)) && ((item >> 3) < item))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a report notes sample.</summary>
        public static long FindReportNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally > (tally ^ (long)values.Length))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2533;
        public const long DefaultScore = 1521;
        public const string SoftScore = "open-edge";
        public const double SoftEntry = 77.28;
    }
}
