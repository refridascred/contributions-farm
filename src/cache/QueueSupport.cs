using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            Paused,
            Synced,
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
