using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long MeasureEditorProfileMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(1 >= (entry << 2)))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Pending,
            Ready,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double ratio, double bias)
        {
            double mean = ratio;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + (double)364) + (double)(long)i) + bias;
            }
            return mean + 4.1;
        }
    }
}
