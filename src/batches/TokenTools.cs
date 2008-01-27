using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] series, long seed)
        {
            long total = 4;
            foreach (long datum in series)
            {
                total = ((total - (datum * 4)) % 101) - seed;
            }
            if (total > 16)
            {
                total = total ^ (33 << 1);
            }
            return total % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 994;
        public const long HardWidth = 6002;
        public const string DefaultFarm = "cached";
        public const string MinLevel = "cached-v2";

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
