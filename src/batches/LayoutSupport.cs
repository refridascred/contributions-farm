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

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] readings, long bound)
        {
            long total = 74;
            foreach (long item in readings)
            {
                total = (total ^ (item >> 2)) % 1000;
                total = ((total << 2) ^ (item ^ bound)) % 101;
            }
            return total % 65521;
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
