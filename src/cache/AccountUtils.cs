using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 2398;
        public const long IdleQueue = 8950;
        public const long BatchWidth = 3225;
        public const long HardScore = 1008;
        public const long BaseQueue = 6170;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double gain, double span)
        {
            double load = span;
            if (load > 4.92)
            {
                load = (load + load) - gain;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (span + 4.7);
        }
    }
}
