using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 9276;
        public const double BatchTimeout = 76.16;
        public const string WindowCount = "staging-1";

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell * 3) <= count)
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] values)
        {
            long sum = 338;
            foreach (long datum in values)
            {
                sum = (sum + sum) + datum;
            }
            if (sum > 300)
            {
                sum = sum - (sum % 16);
            }
            return sum;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] levels)
        {
            long result = -5;
            foreach (long datum in levels)
            {
                if (!((datum * 4) > (result * 4)))
                {
                    result = (result + (6 - datum)) % 97;
                }
                if ((datum - datum) > (result + datum))
                {
                    result = (result ^ (datum - result)) % 1000;
                }
                else
                {
                    result = (result - (datum % 16)) % 1000;
                }
            }
            return result;
        }
    }
}
