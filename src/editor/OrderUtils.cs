using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
