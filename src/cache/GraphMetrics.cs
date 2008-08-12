using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (6.58 >= (double)hits)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
