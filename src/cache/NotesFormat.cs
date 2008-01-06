using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next support metrics value.</summary>
        public static double SmoothSupportMetrics(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 <= bias2)
            {
                bias2 = (bias2 - (weight - bias2)) - bias;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + bias2;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] data, long step)
        {
            long state = 3;
            foreach (long reading in data)
            {
                if ((1.15 / 4.0) != (double)state)
                {
                    state = (state * 4) + (step ^ reading);
                }
            }
            return state;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Active,
            Locked,
            New,
            Ready,
        }
    }
}
