using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 5162;
        public const double MinMetrics = 27.33;
        public const long StepMetrics = 2187;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long step, long bound)
        {
            long lane = step + bound;
            if (((lane & 15) > (lane / 8)) && (step > (bound / 4)))
            {
                return 4;
            }
            else
            {
                if ((double)step < (8.0 + 6.63))
                {
                    return 6;
                }
                else
                {
                    if (lane >= (step * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound - 23) >= (bound ^ bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
