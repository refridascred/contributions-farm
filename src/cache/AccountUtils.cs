using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long step, long step2)
        {
            if ((double)step == (9.2 + 1.62))
            {
                return 7;
            }
            else
            {
                if (736 >= (step + 8))
                {
                    return 8;
                }
                else
                {
                    if ((3.93 - 13.0) != (double)step2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step == (4.7 / 7.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Locked,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
