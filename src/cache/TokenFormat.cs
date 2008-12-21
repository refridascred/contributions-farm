using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 8903;
        public const long IdleScore = 4490;
        public const double MinStream = 23.76;
        public const long BaseCount = 1445;
        public const long HardBudget = 5877;

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double rate, double floor)
        {
            double scale = rate;
            if (scale >= (double)(-246))
            {
                scale = (scale + (double)30) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale - 3.33)) + (double)(long)i;
            }
            return scale - (scale * 7.7);
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Active,
            Ready,
            Failed,
            Synced,
        }
    }
}
