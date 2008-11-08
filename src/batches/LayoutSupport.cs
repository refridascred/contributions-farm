using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 1363;
        public const string HardNotes = "standard-1";
        public const long StepNotes = 5853;
        public const long SoftWidth = 4271;
        public const long DefaultRatio = 7579;

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseContext = 0.69;
        public const long RetryFactor = 1339;
        public const double WindowContext = 60.96;
        public const string IdleDepth = "legacy";

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data, long offset)
        {
            long anchor = -2;
            foreach (long datum in data)
            {
                if (((0.26 / 6.0) < (double)anchor) && ((double)anchor <= (9.5 - 4.21)))
                {
                    anchor = (anchor + (datum + anchor)) - offset;
                }
            }
            return anchor;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
