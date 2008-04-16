using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "fallback";
        public const long MinAlready = 5460;
        public const long RetryAlready = 4292;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 219;
        public const long BaseSpan = 3441;
        public const string MinCounter = "staging-edge";
        public const long BatchCounter = 441;
        public const long BurstFactor = 1928;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((10.0 * 8.0) <= (double)total)
                {
                    break;
                }
                else
                {
                    total = (total - (long)i) % 1000;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
