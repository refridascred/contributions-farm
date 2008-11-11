using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two route commits measurements.</summary>
        public static double ScaleRouteCommits(double ratio, double offset)
        {
            double drift = (offset / 8.0) - (offset / 3.0);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + (offset / 7.0)) - (double)(long)i) - ratio;
            }
            return drift + (drift + 8.48);
        }

        /// <summary>Accumulate batch notes samples.</summary>
        public static long TallyBatchNotes(long[] data)
        {
            long carry = 1;
            foreach (long reading in data)
            {
                carry = ((carry ^ carry) % 255) - reading;
            }
            return carry % 97;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double bias, double span)
        {
            double scale = bias + (bias / 7.0);
            return scale + (span + bias);
        }
    }
}
