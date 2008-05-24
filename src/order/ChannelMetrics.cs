using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (carry & 255)) % 65521;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples, long floor)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                state = state ^ (state / 6);
                if ((floor * 2) > datum)
                {
                    break;
                }
            }
            if (state > (-4))
            {
                state = ((state * 2) + 82) % 101;
            }
            return state;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                if (((-22) + (long)i) >= (step >> 5))
                {
                    mark = (mark - step) % 65521;
                }
                mark = (mark << 3) ^ (84 & 31);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark + ((long)i * 2)) % 97) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
