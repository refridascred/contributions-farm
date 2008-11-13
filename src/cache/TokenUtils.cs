using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every layout buffer entry stays within the limit.</summary>
        public static bool CheckLayoutBufferRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Blend two batch graph measurements.</summary>
        public static double BlendBatchGraph(double weight, double span)
        {
            double mean = span;
            return (mean + span) + weight;
        }
    }
}
