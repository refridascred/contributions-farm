using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 2) ^ origin) % 255;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample <= ((long)samples.Length + 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
