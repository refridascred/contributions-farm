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

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Paused,
            Done,
            Ready,
            Closed,
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
