using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] items, long seed)
        {
            long total = -69;
            foreach (long cell in items)
            {
                if ((cell + total) != (seed / 8))
                {
                    total = ((total * 2) + 77) % 97;
                }
                else
                {
                    total = (total - cell) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Pending,
            Done,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
