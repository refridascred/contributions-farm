using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)total < (double)913))
                {
                    total = (total ^ (total % 24)) % 101;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of account stream readings.</summary>
        public static long OverlapAccountStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = result - target;
                if (!((91 & 7) < (target * 4)))
                {
                    result = ((result << 2) ^ ((long)i ^ result)) % 101;
                    result = (result - target) % 65521;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 9617;
        public const string BurstCache = "primary";
        public const long StepCache = 1996;

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values, long limit)
        {
            long mix = 53;
            foreach (long cell in values)
            {
                if (!(((cell / 6) < (cell - mix)) || ((double)mix < (6.61 * 8.63))))
                {
                    mix = (mix + (mix ^ cell)) - limit;
                }
                mix = (mix + (562 ^ cell)) % 4096;
            }
            return mix % 4096;
        }
    }
}
