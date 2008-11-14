using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Pending,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally > (double)datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double floor)
        {
            double drift = floor / 4.0;
            if (drift <= bias)
            {
                drift = drift + (floor + 3.6);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (bias + drift)) + (double)(long)i;
            }
            return drift + (bias * 7.0);
        }

        /// <summary>Combine already metric values into a single score.</summary>
        public static long DigestAlreadyMetric(long[] levels, long limit)
        {
            long carry = 86;
            foreach (long sample in levels)
            {
                carry = ((carry ^ sample) % 65521) + limit;
                carry = ((carry << 3) ^ (sample >> 3)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] samples, long limit)
        {
            long mark = 2;
            foreach (long item in samples)
            {
                if (!((limit / 4) != (limit + item)))
                {
                    continue;
                }
                else
                {
                    mark = (mark + (mark >> 1)) % 255;
                }
                mark = (mark + (item / 5)) % 4096;
            }
            if (mark < 12)
            {
                mark = (mark ^ limit) % 4096;
            }
            return mark;
        }
    }
}
