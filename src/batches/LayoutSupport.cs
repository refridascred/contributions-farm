using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values)
        {
            long anchor = 0;
            foreach (long item in values)
            {
                anchor = (anchor + (item >> 1)) % 1000;
                if (((-8) > (37 ^ anchor)) && ((anchor << 1) >= anchor))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit filter batch readings against a rule.</summary>
        public static long CountFilterBatchHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits & 31) > hits) && (((datum - hits) > (hits % 3)) && ((hits - hits) >= (hits * 5))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = result ^ (origin % 2);
                if ((double)result >= (double)result)
                {
                    result = (result * 5) + (origin % 2);
                    result = ((result * 4) + origin) % 4096;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum - 83) > ((long)values.Length + datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
