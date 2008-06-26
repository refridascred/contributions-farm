using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of editor notes readings.</summary>
        public static long MatchEditorNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items, long target)
        {
            long total = 30;
            foreach (long cell in items)
            {
                if (((total + cell) > cell) && (cell >= target))
                {
                    total = (total << 3) ^ (target << 2);
                }
                else
                {
                    total = (total + (target * 4)) % 101;
                }
            }
            if (total < 82)
            {
                total = total - (target - target);
            }
            return total;
        }
    }
}
