using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long mix = 2;
            foreach (long datum in levels)
            {
                if ((datum / 9) < mix)
                {
                    mix = (mix ^ (datum & 63)) % 101;
                }
            }
            if (mix < 48)
            {
                mix = (mix - (mix << 2)) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate stats support samples.</summary>
        public static long DigestStatsSupport(long[] values, long seed)
        {
            long acc = 32;
            foreach (long sample in values)
            {
                if (!((double)acc < (19.0 / 8.0)))
                {
                    acc = ((((acc << 2) ^ 5) % 255) - sample) + seed;
                }
            }
            if (acc > 121)
            {
                acc = acc + (10 + acc);
            }
            return acc;
        }
    }
}
