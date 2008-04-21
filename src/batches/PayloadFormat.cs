using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two command filter measurements.</summary>
        public static double SmoothCommandFilter(double ratio, double span)
        {
            double gain = ratio - (20.0 - span);
            return gain + (span + ratio);
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Dropped,
            Queued,
            Idle,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((double)carry < (8.0 * 4.27)) && (carry < ((long)i & 127)))
                {
                    carry = (carry ^ ((long)i * 4)) % 255;
                    break;
                }
                else
                {
                    carry = ((carry * 3) + (seed + seed)) % 1000;
                }
                if (seed < (seed ^ seed))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Done,
            Ready,
            Locked,
        }
    }
}
