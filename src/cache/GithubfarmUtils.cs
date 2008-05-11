using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next payload already value from a seed.</summary>
        public static long StepPayloadAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - (638 & 255);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (((acc * 3) + ((long)i << 3)) % 97) + (long)i2;
                    acc = (acc * 4) + (acc % 64);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items, long bound)
        {
            long score = 33;
            foreach (long reading in items)
            {
                score = ((score ^ (score * 3)) % 101) - reading;
            }
            if (score > 66)
            {
                score = (score ^ (bound >> 3)) % 97;
            }
            return score % 97;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] items)
        {
            long state = 367;
            foreach (long datum in items)
            {
                state = ((state ^ state) % 4096) - datum;
            }
            if (state < 6)
            {
                state = state + state;
            }
            return state % 1000;
        }
    }
}
