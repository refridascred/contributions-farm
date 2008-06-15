using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 > gain)
            {
                gain2 = (gain2 - (double)98) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + 3.38) + (double)(long)i;
            }
            return gain2 - (double)6;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((limit * 3) > limit)
                {
                    state = state - state;
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((mark % 7) == (origin ^ (long)i))
                {
                    mark = mark + (mark ^ mark);
                    mark = (mark - (origin + (long)i)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark >> 2)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
