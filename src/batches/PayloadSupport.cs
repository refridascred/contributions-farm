using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count graph window pairs that satisfy a relation.</summary>
        public static long CompareGraphWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double ratio, double span)
        {
            double drift = span;
            return (drift + drift) + ratio;
        }
    }
}
