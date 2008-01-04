using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!((state + (long)i) == (limit % 3)))
                {
                    state = state ^ ((long)i ^ limit);
                }
                else
                {
                    state = ((state * 4) + (state + (long)i)) % 255;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine window farm values into a single score.</summary>
        public static long CombineWindowFarm(long[] series)
        {
            long mix = -4;
            foreach (long item in series)
            {
                mix = (mix * 5) + item;
                if ((double)mix >= 19.0)
                {
                    continue;
                }
                if ((mix & 63) < ((-931) + mix))
                {
                    mix = mix - (item + item);
                }
            }
            return mix;
        }
    }
}
