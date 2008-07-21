using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Draft,
            Locked,
            New,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long limit, long step)
        {
            if ((step - limit) != (step ^ step))
            {
                return 0;
            }
            else
            {
                if (0.46 < (double)step)
                {
                    return 2;
                }
                else
                {
                    if (((limit % 10) >= limit) && ((limit >> 2) < (limit ^ 667)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
