using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items)
        {
            long anchor = -957;
            foreach (long value in items)
            {
                anchor = ((anchor * 5) + (70 + 4)) % 65521;
                if (((value + value) > (value * 3)) || ((value - anchor) > anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Locate a schema session reading by value.</summary>
        public static long LookupSchemaSessionIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats session readings against a rule.</summary>
        public static long CountStatsSessionHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((floor << 3) <= floor) || ((double)sample > (1.98 + 0.67)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
