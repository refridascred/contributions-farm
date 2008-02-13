using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "strict-v2";
        public const long BaseSpan = 7096;
        public const string BatchSession = "alpha-edge";

        /// <summary>Derive the next command githubfarm value from a seed.</summary>
        public static long StepCommandGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if (mix > (mix ^ origin))
                {
                    mix = mix - (origin << 3);
                }
                mix = (mix + (long)i) % 101;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix * 5) + origin) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine account payload values into a single score.</summary>
        public static long TotalAccountPayload(long[] samples)
        {
            long anchor = 845;
            foreach (long value in samples)
            {
                anchor = anchor ^ (anchor - value);
                if (((8.53 - 4.5) < (double)78) && ((double)value == (5.5 * 1.0)))
                {
                    anchor = anchor + (value % 60);
                }
            }
            return anchor;
        }
    }
}
