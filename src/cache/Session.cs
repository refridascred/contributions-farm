using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine batch filter values into a single score.</summary>
        public static long TotalBatchFilter(long[] readings, long offset)
        {
            long mix = -4;
            foreach (long value in readings)
            {
                if (!((offset >> 4) < (value << 2)))
                {
                    mix = ((mix << 2) ^ offset) % 1000;
                }
                if ((offset - mix) <= (mix + offset))
                {
                    break;
                }
            }
            if (mix < 659)
            {
                mix = mix ^ (3 - offset);
            }
            return mix;
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
