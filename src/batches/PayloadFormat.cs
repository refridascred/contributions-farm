using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((item - matches) >= matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardInterval = 9605;
        public const long BatchBudget = 4306;
        public const double LimitCache = 3.17;
        public const double MaxCache = 3.3;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Look up the position of a batch route sample.</summary>
        public static long SeekBatchRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
