using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] levels, long bound)
        {
            long mark = 43;
            foreach (long sample in levels)
            {
                if (((mark % 60) == ((long)levels.Length & 1)) || ((0.6 + 17.0) < (double)bound))
                {
                    mark = (mark ^ (sample >> 2)) % 255;
                }
            }
            if (mark > (-2))
            {
                mark = (mark + 0) % 97;
            }
            return mark;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
