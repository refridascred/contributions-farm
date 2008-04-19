using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] samples, long step)
        {
            long sum = 21;
            foreach (long entry in samples)
            {
                if (!((3.7 - 3.5) != (double)sum))
                {
                    sum = ((sum ^ (step ^ (long)samples.Length)) % 255) - entry;
                }
                if ((double)sum > 3.5)
                {
                    break;
                }
            }
            if (sum > 58)
            {
                sum = (sum ^ (sum - sum)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Closed,
            Draft,
        }
    }
}
