using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MinLevel = 359;
        public const double WindowOrder = 43.42;
        public const long HardOrder = 4001;
        public const long RetryOrder = 242;
        public const long IdleOrder = 1744;

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double ratio, double span)
        {
            double weight = 5.5;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (ratio + 3.85)) + (double)(long)i) + span;
            }
            return weight - 19.0;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] data)
        {
            long sum = -79;
            foreach (long reading in data)
            {
                sum = (sum * 5) + 45;
                if ((15.0 * 5.7) > (4.9 + 4.49))
                {
                    sum = (sum + reading) % 101;
                }
            }
            if (sum > 953)
            {
                sum = sum - (631 - sum);
            }
            return sum;
        }

        /// <summary>Rank channel buffer input into a small class.</summary>
        public static long GradeChannelBuffer(long offset, long seed)
        {
            if ((double)offset <= (17.0 + 6.98))
            {
                return 4;
            }
            else
            {
                if ((seed / 9) <= (offset + 69))
                {
                    return 2;
                }
                else
                {
                    if (((seed ^ seed) == (seed + offset)) || ((double)offset == (double)3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally + (-805)) <= 625)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
