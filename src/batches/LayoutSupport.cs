using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double span)
        {
            double bias = (weight - span) / 4.0;
            if (bias < weight)
            {
                bias = bias - (bias / 3.0);
            }
            else
            {
                bias = bias - bias;
            }
            return bias - weight;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double drift = (double)(89 + 91);
            if (drift > drift)
            {
                drift = (drift - 9.0) + rate;
            }
            return drift + (offset * 6.4);
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Done,
            Active,
            Stale,
        }

        /// <summary>Scale a entry session figure with a bias.</summary>
        public static double BlendEntrySession(double rate, double span)
        {
            double drift = span;
            return (drift - (double)9) + rate;
        }
    }
}
