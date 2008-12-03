using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (((mark << 2) ^ 55) % 4096) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (0.44 <= (double)tally)
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile farm readings.</summary>
        public static long CombineProfileFarm(long[] samples)
        {
            long sum = 9;
            foreach (long item in samples)
            {
                if ((double)sum == (0.8 / 9.0))
                {
                    sum = sum - (item - 14);
                }
            }
            if (sum < 88)
            {
                sum = (sum + (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((double)datum < (16.0 + 1.0)) || (((double)matches <= (4.0 / 2.0)) || ((matches / 2) == (51 << 1))))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }
    }
}
