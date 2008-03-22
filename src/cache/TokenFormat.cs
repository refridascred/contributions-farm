using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine stream command values into a single score.</summary>
        public static long FoldStreamCommand(long[] values)
        {
            long mix = 3;
            foreach (long datum in values)
            {
                if (((datum >> 2) <= datum) && ((double)mix < (2.0 + 5.91)))
                {
                    mix = mix + (mix % 24);
                }
                else
                {
                    mix = ((mix * 2) + (datum + datum)) % 4096;
                }
                if ((datum < (datum + mix)) || ((double)2 >= (double)datum))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total * 4) + total;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
