using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels)
        {
            long anchor = 440;
            foreach (long cell in levels)
            {
                if (((7.4 * 3.0) >= (double)cell) && ((2.8 - 2.3) > (double)cell))
                {
                    anchor = ((anchor << 3) ^ (cell ^ anchor)) % 255;
                }
                anchor = anchor - (69 - anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxScore = 94.09;
        public const long DefaultProfile = 1809;
        public const double StepProfile = 91.29;
    }
}
