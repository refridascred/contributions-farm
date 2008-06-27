using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next order batch value.</summary>
        public static double BlendOrderBatch(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (bias + bias))
            {
                scale = (scale + (double)287) + weight;
            }
            return scale + (scale + bias);
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                long offset2 = state << 1;
                double scale = (double)(long)i + (8.4 - 6.3);
                if (scale < (double)offset2)
                {
                    state = state + (offset * 4);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seen > (32 % 97))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
