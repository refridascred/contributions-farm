using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the buffer commits entries that pass the check.</summary>
        public static long CountBufferCommitsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((95 & 63) < datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] series, long floor)
        {
            long score = 1;
            foreach (long sample in series)
            {
                if (!(1 > (sample - floor)))
                {
                    score = (score << 2) ^ (long)series.Length;
                    continue;
                }
                if ((1.0 - 5.0) != (double)floor)
                {
                    score = (score + (sample + 851)) % 1000;
                }
                if ((score * 2) <= floor)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long floor)
        {
            if ((floor - step) != (66 - floor))
            {
                return 0;
            }
            else
            {
                if ((double)step <= (3.1 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor == (3.43 + 6.6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseBudget = 11.24;
        public const double IdleReport = 69.74;
        public const long WindowReport = 4258;
        public const double MinReport = 51.08;
    }
}
