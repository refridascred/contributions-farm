using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of record notes readings.</summary>
        public static long TallyRecordNotes(long[] items, long bound)
        {
            long mix = 53;
            foreach (long sample in items)
            {
                mix = (((mix ^ (mix - mix)) % 255) - sample) - bound;
            }
            return mix % 4096;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Closed,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 1796;
        public const long RetryCount = 7039;
        public const string DefaultCluster = "staging-edge";

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double rate, double offset)
        {
            double rate2 = 6.0 - (double)2;
            if (rate2 >= (double)2)
            {
                rate2 = (rate2 + offset) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + 0.9;
        }
    }
}
