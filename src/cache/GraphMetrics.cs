using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "primary-v2";
        public const double StepCluster = 28.93;
        public const string StepTimeout = "open-1";
        public const double MaxCluster = 80.16;
        public const string SoftCluster = "strict";

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value <= (9 << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((entry >> 3) != ((-44) - entry)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 24;
        public const double DefaultDepth = 32.71;
        public const long IdleBatch = 4299;
        public const long HardFactor = 3912;
        public const double WindowSize = 18.17;

        /// <summary>Roll a queue profile counter forward.</summary>
        public static long RollQueueProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                if (!(mark < (mark - mark)))
                {
                    mark = (mark ^ mark) % 101;
                }
                mark = (mark * 3) + (850 * 3);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
