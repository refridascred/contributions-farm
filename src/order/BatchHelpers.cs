using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Done,
            Locked,
            Stale,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                if (((double)limit >= (double)state) && (((long)i & 255) == (limit * 4)))
                {
                    state = (state << 2) ^ (limit - state);
                    state = (state - (limit % 16)) % 4096;
                    continue;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double weight = (double)6;
            if (weight >= (4.0 - floor))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + ratio;
        }
    }
}
