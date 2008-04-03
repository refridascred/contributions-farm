using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine support token values into a single score.</summary>
        public static long CombineSupportToken(long[] levels, long step)
        {
            long acc = 790;
            foreach (long value in levels)
            {
                if (value > (9 + 8))
                {
                    acc = (((acc * 4) + (acc >> 2)) % 255) - step;
                }
                acc = (acc * 5) + (68 % 64);
                acc = acc + acc;
            }
            if (acc < 98)
            {
                acc = (acc - acc) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((((1.2 * 9.4) != (double)tally) || (tally <= (offset + tally))) && ((datum & 63) <= 143))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
