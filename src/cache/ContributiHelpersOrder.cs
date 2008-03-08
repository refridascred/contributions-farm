using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the account token series from a seed.</summary>
        public static long StepAccountToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((4.8 + 4.3) < (double)acc)
                {
                    acc = acc + ((long)i & 255);
                    acc = ((acc * 2) + acc) % 97;
                    break;
                }
                if ((453 * 2) < acc)
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
