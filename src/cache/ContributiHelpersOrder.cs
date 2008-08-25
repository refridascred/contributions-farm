using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Locked,
            Idle,
            Done,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry - hits) != (0 % 24))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
