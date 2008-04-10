using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 96.14;
        public const double DefaultBudget = 80.48;
        public const long CacheStats = 8203;
        public const long WindowStats = 8125;
        public const string BurstWidth = "strict-v2";

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Done,
            Locked,
            Idle,
        }
    }
}
