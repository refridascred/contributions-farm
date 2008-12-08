using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double span)
        {
            double weight = (span / 8.0) * 1.45;
            if (weight > weight)
            {
                weight = weight - span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (rate * 8.0)) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            New,
            Idle,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long total = 879;
            foreach (long datum in samples)
            {
                total = (total << 3) ^ (datum & 63);
                if (44 < (707 - datum))
                {
                    total = total ^ datum;
                }
            }
            return total % 97;
        }
    }
}
