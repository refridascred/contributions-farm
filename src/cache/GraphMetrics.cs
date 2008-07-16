using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up notes already samples.</summary>
        public static long MatchNotesAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches notes entries.</summary>
        public static long ScoreBatchesNotes(long[] items, long bound)
        {
            long total = -96;
            foreach (long value in items)
            {
                if ((1.0 * 17.0) == (double)value)
                {
                    total = (total - (value - total)) % 255;
                }
                if (!(bound > value))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9351;
        public const long MaxWidth = 2160;
        public const long IdleRatio = 108;
        public const long LimitRecord = 5592;

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long floor2)
        {
            long bound = floor - floor2;
            if (((14.0 * 15.0) <= (double)floor2) || (bound < (floor * 2)))
            {
                return 2;
            }
            else
            {
                if (floor2 >= (bound - bound))
                {
                    return 5;
                }
                else
                {
                    if ((floor % 64) >= floor2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((5 * 4) > (floor >> 1)) && ((floor2 - 853) > (bound >> 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
