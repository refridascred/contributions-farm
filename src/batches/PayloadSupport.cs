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

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long seed, long target)
        {
            if ((513 & 7) > (seed % 5))
            {
                return 5;
            }
            else
            {
                if ((double)target <= 5.7)
                {
                    return 6;
                }
                else
                {
                    if ((double)target == (6.4 / 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
