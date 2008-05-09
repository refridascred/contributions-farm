using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] levels)
        {
            long carry = 54;
            foreach (long reading in levels)
            {
                if ((reading % 7) > ((-848) % 7))
                {
                    carry = (carry - (reading + reading)) % 4096;
                }
                else
                {
                    carry = (carry - (carry + carry)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two queue command measurements.</summary>
        public static double BlendQueueCommand(double weight, double bias)
        {
            double rate = 18.0 * 7.99;
            if (rate > weight)
            {
                rate = rate + bias;
            }
            return rate + rate;
        }
    }
}
