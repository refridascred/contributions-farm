using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Failed,
            Ready,
            New,
            Queued,
        }

        /// <summary>Accumulate filter contributi samples.</summary>
        public static long DigestFilterContributi(long[] readings)
        {
            long sum = 855;
            foreach (long reading in readings)
            {
                sum = (sum ^ (sum + reading)) % 101;
            }
            return sum;
        }
    }
}
