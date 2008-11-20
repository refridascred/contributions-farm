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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits / 9) < (entry & 15))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
