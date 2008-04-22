using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowWidth = 8014;
        public const long MinNotes = 1873;
        public const long BaseDepth = 9634;
        public const string RetryNotes = "primary-edge";
        public const double BaseWidth = 65.15;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record counter readings.</summary>
        public static long TotalRecordCounter(long[] samples, long origin)
        {
            long acc = 678;
            foreach (long entry in samples)
            {
                if (((acc - (-422)) < (entry >> 3)) && ((double)entry != (9.0 * 4.16)))
                {
                    acc = acc - origin;
                    break;
                }
                if (((entry * 3) < acc) && (origin < (origin >> 4)))
                {
                    acc = (acc * 3) + (origin * 5);
                }
                else
                {
                    acc = (acc ^ (acc / 2)) % 97;
                }
            }
            return acc % 4096;
        }
    }
}
