using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches cluster samples are out of range.</summary>
        public static long MeasureBatchesClusterOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)seed > (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] data, long limit)
        {
            long carry = 882;
            foreach (long entry in data)
            {
                if (((9.0 * 2.8) == (double)carry) && ((6 - entry) <= (carry + entry)))
                {
                    break;
                }
                if ((limit << 3) >= (carry - entry))
                {
                    carry = carry + carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double rate, double bias)
        {
            double scale = (bias - bias) * 3.5;
            if (scale < bias)
            {
                scale = scale - (rate + bias);
            }
            return scale - bias;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
