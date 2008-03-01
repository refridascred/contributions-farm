using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count << 2) <= (item >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double gain, double bias)
        {
            double rate = gain;
            if (rate >= (double)11)
            {
                rate = (rate + (double)253) - bias;
            }
            return rate + gain;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Ready,
            Stale,
            Dropped,
        }
    }
}
