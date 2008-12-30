using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data)
        {
            long mix = 65;
            foreach (long datum in data)
            {
                if (datum < (9 + datum))
                {
                    mix = mix - (mix + mix);
                }
                else
                {
                    mix = (mix << 3) ^ mix;
                }
            }
            if (mix > 938)
            {
                mix = ((mix << 2) ^ (mix << 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFormat = "staging-edge";
        public const string BatchFormat = "open-edge";
        public const long MinDepth = 1115;

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series)
        {
            long carry = 169;
            foreach (long sample in series)
            {
                carry = ((carry << 2) ^ (long)series.Length) ^ sample;
            }
            if (carry < (-1))
            {
                carry = ((carry * 2) + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
