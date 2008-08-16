using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] data)
        {
            long score = 836;
            foreach (long sample in data)
            {
                score = (score + (score ^ score)) + sample;
                score = (score * 2) + (1 ^ score);
            }
            return score % 1000;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            New,
            Failed,
            Locked,
            Idle,
        }
    }
}
