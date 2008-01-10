using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string StepCount = "fallback-edge";
        public const long IdleAlready = 7407;
        public const double BatchScore = 85.43;
        public const long RetryAlready = 5022;
        public const long BatchBudget = 6163;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a order session counter forward.</summary>
        public static long DeriveOrderSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 3) ^ ((long)i - (long)i)) % 255;
                score = (score * 2) + (offset & 1);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
