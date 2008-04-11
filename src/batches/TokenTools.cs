using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items, long bound)
        {
            long anchor = 137;
            foreach (long entry in items)
            {
                anchor = (anchor ^ anchor) % 97;
                if (entry >= (entry >> 4))
                {
                    break;
                }
            }
            if (anchor < (-3))
            {
                anchor = (anchor - (891 + bound)) % 255;
            }
            return anchor;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Label { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
