using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every route record entry stays within the limit.</summary>
        public static bool CheckRouteRecordBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            New,
            Stale,
            Paused,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "alpha-v2";
        public const string StepFarm = "stable";
        public const long RetryFarm = 8642;
        public const long LimitWidth = 7763;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                if (903 <= (long)i)
                {
                    continue;
                }
                total = (total << 2) ^ offset;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
