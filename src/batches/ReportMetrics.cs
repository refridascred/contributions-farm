using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a cache schema sample.</summary>
        public static long LocateCacheSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            New,
            Ready,
            Closed,
            Done,
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double gain, double bias)
        {
            double drift = bias;
            if (drift <= (gain + drift))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)0) + (double)(long)i;
            }
            return drift - (double)(-69);
        }
    }
}
