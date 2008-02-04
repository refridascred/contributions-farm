using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Iterate the layout order series from a seed.</summary>
        public static long StepLayoutOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i - 21) > (target + target)))
                {
                    result = (result + (target * 4)) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 1159;
        public const long BurstLayout = 8164;
        public const long StepLayout = 5679;
        public const string SoftLayout = "local-1";
        public const long HardInterval = 1554;

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "cached-1";
        public const double LimitInterval = 64.62;
        public const string SoftAlready = "primary-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftScore = 2633;
        public const long BaseEntry = 3885;
        public const long LimitEntry = 2174;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
