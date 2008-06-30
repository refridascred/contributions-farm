using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] values)
        {
            long anchor = 167;
            foreach (long item in values)
            {
                if ((214 + anchor) == (item << 3))
                {
                    anchor = anchor - (anchor ^ anchor);
                }
            }
            if (anchor < 1)
            {
                anchor = anchor + (874 - anchor);
            }
            return anchor;
        }

        /// <summary>Iterate the cache format series from a seed.</summary>
        public static long StepCacheFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ (target / 4)) % 255;
                result = result ^ (target << 3);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] readings)
        {
            long carry = 1;
            foreach (long datum in readings)
            {
                if ((double)datum >= 9.2)
                {
                    carry = (carry ^ (datum + datum)) % 255;
                }
            }
            return carry % 65521;
        }
    }
}
