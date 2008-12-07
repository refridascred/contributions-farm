using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of payload contributi readings.</summary>
        public static long FoldPayloadContributi(long[] items, long seed)
        {
            long carry = 8;
            foreach (long datum in items)
            {
                if (((double)carry <= (1.0 - 7.0)) || ((datum & 63) <= (datum & 15)))
                {
                    carry = (carry ^ (seed & 3)) % 65521;
                }
                else
                {
                    carry = ((carry * 3) + (seed + 91)) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double weight = gain;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)(long)i) - offset;
            }
            return weight + (double)(-26);
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Failed,
            Idle,
            Done,
            Stale,
        }
    }
}
