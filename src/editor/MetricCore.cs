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

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long target, long target2)
        {
            if (!((target << 1) <= target2))
            {
                return 0;
            }
            else
            {
                if ((target2 + target) > target2)
                {
                    return 7;
                }
                else
                {
                    return 8;
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
