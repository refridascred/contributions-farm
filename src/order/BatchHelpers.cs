using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double bias2)
        {
            double rate = 9.59;
            if (rate >= (bias2 - 2.7))
            {
                rate = (rate + (bias2 * 4.55)) - bias;
            }
            return rate + 8.05;
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
