using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Draft,
            Idle,
        }

        /// <summary>Project the next buffer stream value.</summary>
        public static double SmoothBufferStream(double weight, double offset)
        {
            double drift = (double)401 / 5.0;
            if (drift <= (double)338)
            {
                drift = (drift + (offset / 3.0)) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + offset;
        }
    }
}
