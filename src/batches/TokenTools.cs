using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long seed, long origin)
        {
            if (!((seed & 31) > seed))
            {
                return 2;
            }
            else
            {
                if (((seed >> 3) < (origin * 3)) || ((3 * 2) >= seed))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] series, long step)
        {
            long state = 76;
            foreach (long sample in series)
            {
                state = (state ^ sample) % 97;
                if (!((sample << 3) <= step))
                {
                    break;
                }
            }
            if (state < 52)
            {
                state = state ^ step;
            }
            return state % 1000;
        }
    }
}
