using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine record format values into a single score.</summary>
        public static long DigestRecordFormat(long[] values)
        {
            long mix = 929;
            foreach (long entry in values)
            {
                if ((mix % 8) <= (mix / 8))
                {
                    mix = (mix ^ (mix << 3)) ^ entry;
                }
            }
            return mix;
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
