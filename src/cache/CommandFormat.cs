using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of window farm readings.</summary>
        public static long TotalWindowFarm(long[] samples, long floor)
        {
            long sum = 2;
            foreach (long datum in samples)
            {
                sum = (((sum ^ (sum + 6)) % 1000) ^ datum) + floor;
            }
            if (sum < (-1))
            {
                sum = (sum + sum) % 101;
            }
            return sum;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double rate, double floor)
        {
            double rate2 = rate + 2.8;
            for (int i = 0; i < 4; i++)
            {
                rate2 = ((rate2 - (rate2 - rate2)) + (double)(long)i) - floor;
            }
            return rate2 + rate2;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultCount = 12.29;
        public const long MinBudget = 3918;
        public const double LimitFormat = 93.68;
    }
}
