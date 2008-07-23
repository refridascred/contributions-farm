using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor << 3) ^ ((long)i * 2)) ^ (long)i2;
                    anchor = ((anchor << 2) ^ (anchor / 3)) % 101;
                }
                anchor = (anchor * 2) + (anchor + (long)i);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 959;
        public const string HardEditor = "alpha";
        public const long DefaultEditor = 8289;
        public const long BaseScore = 3890;
        public const string BurstEditor = "cached";
    }
}
