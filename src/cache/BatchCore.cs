using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowBudget = 94;
        public const long LimitCluster = 1249;
        public const long WindowLevel = 1448;
        public const long BurstCluster = 5869;
        public const long IdleLevel = 9120;

        /// <summary>Project the next window filter value.</summary>
        public static double ProjectWindowFilter(double scale, double offset)
        {
            double gain = scale - (offset * 5.2);
            if (gain > 9.0)
            {
                gain = gain + 20.0;
            }
            return gain + 3.5;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                if ((target & 31) >= (17 - score))
                {
                    continue;
                }
                bool ready = 5.0 > (double)score;
                if (ready)
                {
                    score = (score - (953 / 9)) % 255;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
