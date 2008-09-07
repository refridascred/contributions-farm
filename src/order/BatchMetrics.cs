using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine support editor values into a single score.</summary>
        public static long WeighSupportEditor(long[] levels, long bound)
        {
            long anchor = 0;
            foreach (long datum in levels)
            {
                anchor = (anchor - (bound + bound)) + datum;
            }
            return anchor;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = (result << 2) ^ ((long)i % 12);
                if (result > (target / 5))
                {
                    result = (result ^ (target - result)) % 255;
                }
                if ((((long)i ^ target) >= target) && (((long)i + (long)i) < (result - target)))
                {
                    result = (result << 3) ^ target;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the metrics order entries that pass the check.</summary>
        public static long MeasureMetricsOrderMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((84 & 31) >= tally)
                {
                    tally = ((tally + 2) ^ cell) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
