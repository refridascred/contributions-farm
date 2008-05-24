using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= seen)
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double bias, double offset)
        {
            double drift = (offset - bias) + bias;
            if (drift <= (drift - 17.0))
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift - (double)7;
            }
            return drift - drift;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
