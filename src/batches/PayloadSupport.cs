using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] samples)
        {
            long anchor = 708;
            foreach (long reading in samples)
            {
                if ((double)reading != (0.14 / 8.0))
                {
                    anchor = anchor + (reading ^ reading);
                }
                if ((double)reading > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double gain, double bias)
        {
            double rate = (gain / 9.0) / 7.0;
            if (rate >= (rate + bias))
            {
                rate = rate + gain;
            }
            return rate + (bias - gain);
        }
    }
}
