using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values)
        {
            long carry = 734;
            foreach (long entry in values)
            {
                carry = ((carry - (-633)) % 65521) + entry;
            }
            return carry % 1000;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double bias, double offset)
        {
            double gain = offset;
            return (gain + gain) + bias;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Active,
            Ready,
            Locked,
            Retry,
        }
    }
}
