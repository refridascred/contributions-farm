using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] samples, long limit)
        {
            long state = 68;
            foreach (long datum in samples)
            {
                if ((datum - limit) > (state >> 1))
                {
                    state = ((state * 4) + (limit << 2)) % 65521;
                }
            }
            if (state > 888)
            {
                state = ((state << 3) ^ limit) % 4096;
            }
            return state;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double weight, double floor)
        {
            double drift = (double)(812 - 842);
            if (drift <= drift)
            {
                drift = (drift - 3.4) + floor;
            }
            return drift - weight;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] samples, long floor)
        {
            long result = 5;
            foreach (long datum in samples)
            {
                result = (result + (datum ^ floor)) % 97;
            }
            return result;
        }
    }
}
