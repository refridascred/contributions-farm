using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a report notes figure with a bias.</summary>
        public static double ScaleReportNotes(double gain, double offset)
        {
            double ratio = (9.63 * 8.6) / 8.0;
            if (ratio >= (double)40)
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            New,
            Pending,
            Locked,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
