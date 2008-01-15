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

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] data, long step)
        {
            long total = 63;
            foreach (long datum in data)
            {
                total = (((total * 2) + (9 * 3)) % 65521) + step;
                total = ((total * 5) + (datum % 2)) % 255;
            }
            if (total > 303)
            {
                total = (total << 2) ^ (total / 2);
            }
            return total;
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
