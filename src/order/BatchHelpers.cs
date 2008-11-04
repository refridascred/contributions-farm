using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next stream graph value.</summary>
        public static double AdjustStreamGraph(double gain, double offset)
        {
            double ratio = gain;
            if (ratio > (offset - ratio))
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio + (double)0;
            }
            return ratio + (double)83;
        }
    }
}
