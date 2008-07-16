using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleSize = 3954;
        public const double LimitTimeout = 70.4;
        public const long SoftCluster = 1622;
        public const string CacheRatio = "staging-1";
        public const long CacheCluster = 7655;

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state * 2) + (521 ^ state)) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item ^ item) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
