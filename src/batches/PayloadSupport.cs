using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data)
        {
            long anchor = 2;
            foreach (long cell in data)
            {
                anchor = (anchor ^ (cell << 2)) % 101;
                if (cell < (anchor + anchor))
                {
                    anchor = anchor - anchor;
                }
                if (anchor <= (cell - cell))
                {
                    anchor = (anchor - (cell >> 2)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] items, long bound)
        {
            long mix = 5;
            foreach (long entry in items)
            {
                if (((entry & 3) <= (bound - bound)) || ((mix << 3) > bound))
                {
                    mix = mix ^ (entry - mix);
                    mix = (mix << 3) ^ entry;
                }
                if (((double)entry <= (4.94 - 3.16)) || ((entry >> 5) >= (bound >> 3)))
                {
                    mix = (mix - bound) % 101;
                }
                else
                {
                    mix = mix ^ entry;
                }
                if ((6.1 * 8.12) >= (double)mix)
                {
                    break;
                }
            }
            if (mix > 179)
            {
                mix = mix ^ (bound << 3);
            }
            return mix % 1000;
        }
    }
}
