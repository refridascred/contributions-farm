using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long sum = 96;
            foreach (long reading in items)
            {
                sum = (sum ^ (sum >> 5)) ^ reading;
            }
            return sum;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (total + target)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
