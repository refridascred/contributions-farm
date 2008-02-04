using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            New,
            Active,
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

        /// <summary>Accumulate format token samples.</summary>
        public static long DigestFormatToken(long[] samples)
        {
            long acc = 1;
            foreach (long value in samples)
            {
                if (!((acc >> 5) >= acc))
                {
                    acc = (acc << 3) ^ (value % 24);
                }
            }
            return acc;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Count { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftScore = 2633;
        public const long BaseEntry = 3885;
        public const long LimitEntry = 2174;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
