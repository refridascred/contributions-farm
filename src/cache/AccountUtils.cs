using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long bound)
        {
            long mix = 499;
            foreach (long sample in series)
            {
                if ((mix % 8) >= bound)
                {
                    mix = (mix << 3) ^ (sample / 3);
                }
                else
                {
                    mix = (mix + (7 ^ mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] data, long bound)
        {
            long mix = 25;
            foreach (long sample in data)
            {
                mix = ((mix + (mix % 12)) ^ sample) - bound;
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }
    }
}
