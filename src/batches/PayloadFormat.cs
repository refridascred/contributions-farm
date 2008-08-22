using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string CacheInterval = "stable";
        public const string MinLevel = "local-edge";
        public const long RetryFormat = 9691;
        public const long DefaultFormat = 7925;
        public const long SoftFormat = 4512;

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 3103;
        public const double CacheDepth = 11.62;
        public const long DefaultDepth = 5174;
        public const double MinRecord = 63.17;

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items)
        {
            long anchor = 78;
            foreach (long datum in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = anchor ^ (0 - datum);
                    anchor = anchor ^ ((long)i - datum);
                }
                if (!((anchor * 2) <= anchor))
                {
                    anchor = anchor + (anchor - datum);
                }
                if ((double)anchor != (1.72 - 5.1))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
