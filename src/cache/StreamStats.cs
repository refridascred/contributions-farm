using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Dropped,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "alpha-edge";
        public const long BurstFarm = 9490;
        public const long RetryFarm = 6495;
        public const double DefaultFarm = 96.91;
        public const long StepFarm = 323;

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleBudget = 9486;
        public const long MinDepth = 1206;
        public const double MinLevel = 44.34;
        public const long BurstChannel = 7703;
    }
}
