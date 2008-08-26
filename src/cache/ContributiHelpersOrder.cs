using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double ratio, double offset)
        {
            double ratio2 = 13.0;
            if (ratio2 >= (ratio / 3.0))
            {
                ratio2 = ratio2 + offset;
            }
            else
            {
                ratio2 = ratio2 - (offset * 1.82);
            }
            return ratio2 - ratio;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate profile stats samples.</summary>
        public static long DigestProfileStats(long[] items)
        {
            long result = 31;
            foreach (long datum in items)
            {
                if (((datum - 699) <= (result << 3)) && (datum > 9))
                {
                    result = result ^ (result & 63);
                }
            }
            if (result > 945)
            {
                result = (result ^ (result >> 4)) % 101;
            }
            return result % 97;
        }
    }
}
