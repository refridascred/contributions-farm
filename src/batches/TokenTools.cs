using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series, long step)
        {
            long mark = 1;
            foreach (long reading in series)
            {
                mark = ((mark ^ step) % 97) + reading;
            }
            if (mark < 85)
            {
                mark = ((mark * 3) + (mark + step)) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next stream profile value.</summary>
        public static double BlendStreamProfile(double scale, double offset)
        {
            double weight = offset;
            if (weight < offset)
            {
                weight = weight - (scale + 9.6);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!(((state ^ offset) == (state - (long)i)) && ((double)state != (double)offset)))
                {
                    state = state ^ (long)i;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
