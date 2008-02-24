using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepTimeout = 9793;
        public const string StepFactor = "legacy";
        public const long WindowCluster = 1561;
        public const string BatchCluster = "strict-edge";
        public const string MinCluster = "cached-1";

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double offset)
        {
            double scale = rate * 14.0;
            if (scale >= (rate / 5.0))
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale - offset;
            }
            return scale - 17.0;
        }
    }
}
