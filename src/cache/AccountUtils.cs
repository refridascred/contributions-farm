using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile layout entries.</summary>
        public static long CombineProfileLayout(long[] values, long step)
        {
            long acc = 93;
            foreach (long cell in values)
            {
                if ((acc << 3) <= cell)
                {
                    acc = ((acc << 2) ^ (cell << 1)) + step;
                    acc = acc - acc;
                    continue;
                }
                acc = (acc << 3) ^ (196 >> 2);
            }
            if (acc < 1)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Done,
            Synced,
        }
    }
}
