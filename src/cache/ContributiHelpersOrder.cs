using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the notes profile entries that pass the check.</summary>
        public static long CountNotesProfileGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((bound - cell) >= (bound * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer record readings against a rule.</summary>
        public static long CountBufferRecordGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + 3) > seen)
                {
                    seen = ((seen + 3) ^ entry) - limit;
                }
            }
            return seen;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
