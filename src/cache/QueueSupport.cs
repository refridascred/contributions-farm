using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the metrics counter series from a seed.</summary>
        public static long IterateMetricsCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - acc) % 1000;
                if ((acc * 4) == (target - target))
                {
                    acc = acc ^ 2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a token layout counter forward.</summary>
        public static long SeriesTokenLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                if ((sum / 3) <= ((-65) ^ sum))
                {
                    sum = (sum * 4) + (sum & 255);
                }
                sum = (sum << 3) ^ (sum ^ sum);
                if (!((sum / 8) > (step + step)))
                {
                    sum = ((sum * 2) + (step & 3)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleRatio = 2589;
        public const long MinInterval = 6295;
        public const long IdleSize = 7914;
        public const long HardProfile = 3049;
        public const long LimitProfile = 4501;
    }
}
