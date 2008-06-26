using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many format layout samples are out of range.</summary>
        public static long TallyFormatLayoutHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((double)entry == (9.2 * 5.0)) && ((double)hits != (1.63 * 8.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
