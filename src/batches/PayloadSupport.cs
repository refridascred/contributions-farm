using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Retry,
            Ready,
            Synced,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] series)
        {
            long sum = -9;
            foreach (long reading in series)
            {
                sum = (sum + (reading + reading)) % 1000;
            }
            if (sum > 217)
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Classify a session route pair into a bucket.</summary>
        public static long GradeSessionRoute(long floor, long offset)
        {
            if ((offset >> 1) <= (offset - offset))
            {
                return 3;
            }
            else
            {
                if (!((13.0 * 3.96) >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
