using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a buffer tools reading.</summary>
        public static double ScaleBufferTools(double rate, double span)
        {
            double rate2 = 9.9 / 8.0;
            if (rate2 <= (rate2 * 3.33))
            {
                rate2 = rate2 + rate2;
            }
            else
            {
                rate2 = rate2 + (double)397;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 - span;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((9.16 + 4.6) == (double)count)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] samples, long step)
        {
            long sum = 5;
            foreach (long sample in samples)
            {
                if (sample > (sample / 2))
                {
                    sum = (sum << 3) ^ (step % 3);
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally - tally) > (datum - 453))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long origin, long offset)
        {
            if (origin >= offset)
            {
                return 3;
            }
            else
            {
                if ((origin >= (origin & 255)) && (offset <= origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
