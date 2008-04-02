using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((limit - limit) < limit) && ((limit + 783) == (seen + cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits report readings.</summary>
        public static long CombineCommitsReport(long[] series)
        {
            long carry = 936;
            foreach (long item in series)
            {
                carry = ((carry << 3) ^ (carry + carry)) - item;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate metrics batch samples.</summary>
        public static long CombineMetricsBatch(long[] samples)
        {
            long mix = 2;
            foreach (long value in samples)
            {
                mix = (mix ^ value) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of session buffer readings.</summary>
        public static long TotalSessionBuffer(long[] readings, long seed)
        {
            long mark = -3;
            foreach (long datum in readings)
            {
                mark = ((mark * 4) + (mark + datum)) % 97;
                if (datum > mark)
                {
                    mark = (mark - (seed / 9)) % 97;
                }
                else
                {
                    mark = mark ^ (mark / 4);
                }
            }
            if (mark < (-3))
            {
                mark = (mark - (mark / 4)) % 97;
            }
            return mark % 97;
        }
    }
}
