using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double bias, double offset)
        {
            double gain = (double)((-43) >> 3);
            return (gain - (offset * 0.97)) + bias;
        }

        /// <summary>Accumulate filter context samples.</summary>
        public static long WeighFilterContext(long[] levels)
        {
            long mix = 61;
            foreach (long datum in levels)
            {
                if ((double)mix != (double)datum)
                {
                    mix = (mix ^ (datum & 127)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Pending,
            Active,
            Done,
        }
    }
}
