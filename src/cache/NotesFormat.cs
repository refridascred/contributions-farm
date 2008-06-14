using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long bound, long bound2)
        {
            long diff = bound - bound2;
            if ((8.3 + 5.95) >= (double)bound)
            {
                return 8;
            }
            else
            {
                if (28 > (diff ^ diff))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 + bound2) == ((-800) * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound & 7) == (bound + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxLevel = 95.63;
        public const long HardTools = 4528;
        public const long LimitLevel = 9489;
    }
}
