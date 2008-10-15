using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                score = (score - step) % 101;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = ((score << 2) ^ score) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long limit, long floor)
        {
            long next = limit - floor;
            if (((-107) - limit) <= (limit - next))
            {
                return 7;
            }
            else
            {
                if (76 >= (limit - limit))
                {
                    return 0;
                }
                else
                {
                    if (limit >= (next + next))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSize = 8478;
        public const double DefaultDepth = 98.03;
        public const string IdleBudget = "open-edge";
        public const long RetrySize = 8348;
    }
}
