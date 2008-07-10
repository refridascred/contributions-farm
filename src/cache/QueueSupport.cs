using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series, long step)
        {
            long carry = 78;
            foreach (long cell in series)
            {
                if (step > 734)
                {
                    carry = carry ^ (19 >> 4);
                }
                else
                {
                    carry = (carry ^ (cell % 97)) % 65521;
                }
                if ((cell % 8) >= (carry % 3))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
