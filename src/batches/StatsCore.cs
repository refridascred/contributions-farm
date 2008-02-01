using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many payload metrics samples are out of range.</summary>
        public static long CountPayloadMetricsHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((step >> 4) <= value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Match up report queue samples.</summary>
        public static long OverlapReportQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitScore = "standard-edge";
        public const double SoftCount = 54.45;
        public const long BatchBatches = 4504;
        public const long BaseBatches = 2590;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseSpan = 50.73;
        public const long RetryCache = 9725;
        public const long BatchCache = 7276;
        public const long StepCache = 7812;
        public const long MaxDepth = 6281;

        /// <summary>Locate a batches channel reading by value.</summary>
        public static long FindBatchesChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
