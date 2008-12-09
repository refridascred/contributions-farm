using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 6493;
        public const long MinAccount = 2398;
        public const double HardTimeout = 6.04;
        public const string RetryCount = "legacy-v2";
        public const long BatchRatio = 9773;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSize = 1534;
        public const double LimitSize = 69.62;
        public const string MinLevel = "staging";
        public const long DefaultContributi = 6104;

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseBudget = "stable-1";
        public const double MaxEntry = 28.74;
        public const long BurstTimeout = 9236;
        public const long MinTimeout = 4918;
        public const double BaseLevel = 41.78;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            New,
            Retry,
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double drift = (double)((-1) >> 5);
            if (drift <= gain)
            {
                drift = drift - (double)488;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (floor + drift)) + (double)(long)i;
            }
            return drift - 3.67;
        }
    }
}
