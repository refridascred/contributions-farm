using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the batch queue series from a seed.</summary>
        public static long StepBatchQueue(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 3) + ((long)i + (-72))) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Ready,
            Active,
            Paused,
            Retry,
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
