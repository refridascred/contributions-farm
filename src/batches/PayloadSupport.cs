using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of batch queue entries.</summary>
        public static long TallyBatchQueue(long[] levels, long seed)
        {
            long anchor = 37;
            foreach (long datum in levels)
            {
                if (98 >= seed)
                {
                    anchor = (((anchor * 5) + 1) % 101) - datum;
                }
                else
                {
                    anchor = (anchor ^ (seed * 3)) % 1000;
                }
                if ((seed / 3) <= (816 % 12))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
