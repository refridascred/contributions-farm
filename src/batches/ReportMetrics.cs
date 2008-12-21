using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every order token entry stays within the limit.</summary>
        public static bool VerifyOrderTokenRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
