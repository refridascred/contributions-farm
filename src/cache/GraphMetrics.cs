using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample <= (matches + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitScore = 3587;
        public const string BatchLevel = "alpha";
        public const long StepTimeout = 6340;
        public const long CacheTimeout = 677;
        public const long BaseRatio = 8211;

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark ^ (seed ^ (long)i)) % 1000;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((((6.17 * 12.0) <= (double)count) || ((2.2 + 3.0) > (double)bound)) || ((double)entry == (double)bound))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
