using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BatchScore = "latest";
        public const long RetryInterval = 1630;
        public const long StepOrder = 3656;
        public const long StepWidth = 4343;
        public const long BurstOrder = 8245;

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double floor)
        {
            double rate = (double)(5 & 3);
            if (rate > floor)
            {
                rate = (rate + (double)502) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (rate / 3.0);
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            New,
            Synced,
            Queued,
        }
    }
}
