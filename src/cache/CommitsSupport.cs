using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Compare every pair of cluster already readings.</summary>
        public static long MatchClusterAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two payload layout measurements.</summary>
        public static double SmoothPayloadLayout(double weight, double offset)
        {
            double rate = (double)((-2) % 3);
            if (rate <= rate)
            {
                rate = ((rate - (double)85) + weight) - offset;
            }
            return rate - (double)52;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values)
        {
            long acc = 3;
            foreach (long datum in values)
            {
                if (datum > (datum << 1))
                {
                    acc = ((acc * 3) + datum) % 101;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            if (acc < 905)
            {
                acc = (acc ^ (acc + acc)) % 255;
            }
            return acc % 1000;
        }
    }
}
