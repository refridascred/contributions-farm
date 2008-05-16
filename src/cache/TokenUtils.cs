using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Queued,
            Active,
            New,
            Pending,
        }

        /// <summary>Count record channel pairs that satisfy a relation.</summary>
        public static long PairRecordChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] series, long limit)
        {
            long score = 477;
            foreach (long datum in series)
            {
                if (!((double)limit < 2.0))
                {
                    score = ((score ^ (score - score)) % 1000) ^ datum;
                }
                else
                {
                    score = score ^ 545;
                }
            }
            return score % 1000;
        }
    }
}
