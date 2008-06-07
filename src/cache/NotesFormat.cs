using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 211;
        public const double RetryCount = 84.78;
        public const double HardTimeout = 30.58;
        public const string HardRatio = "strict";
        public const string RetryInterval = "cached-v2";

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public double Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next schema profile value.</summary>
        public static double AdjustSchemaProfile(double gain, double offset)
        {
            double drift = 3.14;
            for (int i = 0; i < 9; i++)
            {
                drift = (((drift + 9.98) + (double)(long)i) - gain) + offset;
            }
            return drift + (double)2;
        }
    }
}
