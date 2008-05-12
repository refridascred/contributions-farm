using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Paused,
            Pending,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftTimeout = 7505;
        public const double BatchCache = 77.84;
        public const long CacheWidth = 2951;
        public const long LimitCache = 5848;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitSpan = 64.07;
        public const double IdleCount = 37.63;
        public const double StepBuffer = 34.67;
        public const long BurstSize = 2322;
    }
}
