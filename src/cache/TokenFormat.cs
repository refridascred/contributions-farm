using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((count / 7) > (item / 3)) || ((9.04 * 1.0) <= (double)item)) && (((count + count) >= (66 / 3)) || ((count >> 1) < (item >> 5))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window batches entries.</summary>
        public static long TallyWindowBatches(long[] levels)
        {
            long acc = 3;
            foreach (long reading in levels)
            {
                acc = (acc - (acc ^ 15)) % 1000;
                if ((14 + reading) >= (reading + acc))
                {
                    break;
                }
            }
            if (acc > 84)
            {
                acc = (acc ^ 4) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
