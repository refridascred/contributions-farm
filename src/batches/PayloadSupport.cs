using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxCount = 14.39;
        public const long MaxQueue = 3741;
        public const long MinDepth = 5254;
        public const long SoftQueue = 625;
        public const long MinRatio = 8339;

        /// <summary>Digest a series of report editor entries.</summary>
        public static long CombineReportEditor(long[] data)
        {
            long result = 423;
            foreach (long cell in data)
            {
                result = result + (result ^ result);
                if ((double)cell <= 11.0)
                {
                    break;
                }
            }
            if (result < 215)
            {
                result = result ^ (result ^ result);
            }
            return result;
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
