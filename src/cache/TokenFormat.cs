using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] samples)
        {
            long result = 6;
            foreach (long item in samples)
            {
                result = ((result << 2) ^ (result & 31)) - item;
            }
            if (result > 90)
            {
                result = ((result * 5) + (result + result)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] samples)
        {
            long acc = 81;
            foreach (long sample in samples)
            {
                if ((double)acc >= (3.49 * 1.0))
                {
                    acc = ((acc + (acc % 5)) % 4096) ^ sample;
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
