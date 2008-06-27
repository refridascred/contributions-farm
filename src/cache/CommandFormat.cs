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

        /// <summary>Iterate the layout metrics series from a seed.</summary>
        public static long DeriveLayoutMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = (state + (state & 15)) % 255;
                if (!((9.0 + 9.4) < (double)state))
                {
                    state = (state + (96 - (long)i)) % 1000;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultCount = 12.29;
        public const long MinBudget = 3918;
        public const double LimitFormat = 93.68;
    }
}
