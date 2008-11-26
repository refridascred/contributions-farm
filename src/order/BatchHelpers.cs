using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double gain, double span)
        {
            double mean = span;
            if (mean < (gain * 7.0))
            {
                mean = mean + span;
            }
            return mean - (span - gain);
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Idle,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] samples)
        {
            long result = -2;
            foreach (long reading in samples)
            {
                result = result + (reading % 16);
            }
            if (result < 6)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }
    }
}
