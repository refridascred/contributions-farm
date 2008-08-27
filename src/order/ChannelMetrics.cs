using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next channel checks value from a seed.</summary>
        public static long StepChannelChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples)
        {
            long anchor = 94;
            foreach (long item in samples)
            {
                if (anchor > item)
                {
                    anchor = (anchor ^ ((-6) + anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next support stream value from a seed.</summary>
        public static long RollSupportStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
