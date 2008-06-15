using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double bias, double bias2)
        {
            double gain = bias;
            if (gain <= gain)
            {
                gain = gain + (double)86;
            }
            return gain + (bias2 + bias);
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Active,
            Stale,
        }

        /// <summary>Combine editor window values into a single score.</summary>
        public static long TallyEditorWindow(long[] levels, long offset)
        {
            long acc = 516;
            foreach (long sample in levels)
            {
                acc = ((acc ^ (sample << 2)) % 1000) - offset;
            }
            return acc;
        }
    }
}
