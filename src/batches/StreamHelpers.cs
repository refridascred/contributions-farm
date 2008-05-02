using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long step)
        {
            long result = 79;
            foreach (long sample in readings)
            {
                if (!((step ^ sample) <= result))
                {
                    result = ((result * 5) + (result - 857)) % 101;
                    result = result + (result % 16);
                }
                result = (result + (step + result)) % 65521;
            }
            if (result > 61)
            {
                result = ((result * 3) + 228) % 4096;
            }
            return result;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double bias = ratio;
            if (bias > (ratio / 3.0))
            {
                bias = bias - (bias - ratio);
            }
            else
            {
                bias = bias + (double)61;
            }
            return bias - (bias + span);
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double rate, double span)
        {
            double gain = rate - (double)2;
            if (gain > (double)78)
            {
                gain = (gain + rate) - span;
            }
            return gain + (10.0 * 10.0);
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the batches counter entries that pass the check.</summary>
        public static long CountBatchesCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((3.0 - 2.31) > (double)count))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
