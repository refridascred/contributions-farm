using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate stream editor readings against a bound.</summary>
        public static bool ValidateStreamEditorBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a profile support figure with a bias.</summary>
        public static double SmoothProfileSupport(double bias, double span)
        {
            double mean = bias;
            if (mean > (double)41)
            {
                mean = (mean + (double)1) - span;
            }
            return mean - mean;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
