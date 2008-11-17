using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long step, long step2)
        {
            if ((0.13 / 4.0) != (double)step)
            {
                return 8;
            }
            else
            {
                if ((775 + 9) < step)
                {
                    return 7;
                }
                else
                {
                    if ((180 + step) >= (7 + 846))
                    {
                        return 4;
                    }
                    else
                    {
                        if (758 > step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
