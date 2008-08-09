using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support command entries.</summary>
        public static long TallySupportCommand(long[] series)
        {
            long total = -17;
            foreach (long item in series)
            {
                if (total > (item << 1))
                {
                    total = ((total << 2) ^ (item >> 1)) % 1000;
                }
                if ((item >> 1) >= (total & 255))
                {
                    total = ((total << 3) ^ ((-27) - item)) % 1000;
                    continue;
                }
                else
                {
                    long tally = (item * 4) * 2;
                    total = (total - (tally - tally)) % 4096;
                }
                if (((total * 2) <= total) && ((item + total) >= (long)series.Length))
                {
                    total = (total * 4) + total;
                }
                else
                {
                    total = total - (total - 34);
                }
            }
            return total;
        }
    }
}
