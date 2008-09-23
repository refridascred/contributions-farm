using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items, long offset)
        {
            long mix = 641;
            foreach (long entry in items)
            {
                if ((double)offset < 7.4)
                {
                    mix = (mix + (entry % 2)) % 101;
                }
            }
            if (mix > (-19))
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix % 4096;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] values)
        {
            long mark = -4;
            foreach (long datum in values)
            {
                mark = (((mark << 2) ^ (mark * 3)) % 97) + datum;
            }
            if (mark > 17)
            {
                mark = ((mark << 2) ^ (mark / 9)) % 4096;
            }
            return mark % 97;
        }
    }
}
