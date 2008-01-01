using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double weight, double offset)
        {
            double load = (double)(50 ^ 1);
            if (load <= (double)2)
            {
                load = load - (weight - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples)
        {
            long state = 893;
            foreach (long datum in samples)
            {
                if (!((datum + 94) <= (9 + datum)))
                {
                    state = (state + (state - datum)) % 65521;
                }
                if ((datum <= 29) && ((state + datum) <= (47 / 3)))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
