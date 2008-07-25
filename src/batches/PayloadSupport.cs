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

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryDepth = 990;
        public const double BurstEntry = 18.26;
        public const long LimitEntry = 521;
        public const long IdleEntry = 2620;
        public const long StepEntry = 9210;

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
