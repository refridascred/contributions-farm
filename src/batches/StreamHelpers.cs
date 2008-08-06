using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit stream token readings against a rule.</summary>
        public static long TallyStreamTokenGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count > (5.6 * 7.9))
                {
                    count = ((count + 2) + reading) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitInterval = "cached-1";
        public const double BaseLayout = 67.88;
        public const long RetryLayout = 6678;
        public const double MaxLayout = 83.9;
        public const long RetrySize = 7361;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] values)
        {
            long result = 4;
            foreach (long item in values)
            {
                result = (result ^ (item & 1)) % 65521;
                result = (result << 3) ^ (result + item);
                if (result >= 362)
                {
                    result = ((result * 2) + (item / 8)) % 255;
                }
            }
            if (result < (-7))
            {
                result = ((result * 2) + (880 + result)) % 1000;
            }
            return result;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((3.9 / 6.0) < (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples, long bound)
        {
            long mix = -8;
            foreach (long cell in samples)
            {
                mix = ((mix ^ (5 - cell)) % 101) - bound;
            }
            return mix;
        }
    }
}
