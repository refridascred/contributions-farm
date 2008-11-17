using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values)
        {
            long sum = 879;
            foreach (long cell in values)
            {
                sum = (sum + sum) + cell;
            }
            return sum % 97;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many support command samples are out of range.</summary>
        public static long AuditSupportCommandGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (23 <= (hits >> 5))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (3 >= (datum - 673))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
