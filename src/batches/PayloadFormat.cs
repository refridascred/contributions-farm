using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] samples, long step)
        {
            long sum = 68;
            foreach (long entry in samples)
            {
                if (((double)6 <= (double)entry) && ((sum - sum) >= (entry * 5)))
                {
                    sum = (sum ^ (46 / 4)) - step;
                }
                else
                {
                    sum = ((sum * 2) + (sum * 4)) % 97;
                }
            }
            return sum;
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

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
