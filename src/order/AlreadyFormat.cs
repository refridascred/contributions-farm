using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] series)
        {
            long sum = 53;
            foreach (long value in series)
            {
                if ((double)sum == (17.0 - 6.5))
                {
                    sum = ((sum * 4) + value) % 65521;
                }
            }
            if (sum < 7)
            {
                sum = ((sum << 2) ^ sum) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long seed)
        {
            if ((double)seed == (8.0 / 3.0))
            {
                return 3;
            }
            else
            {
                if (((step ^ step) != (37 & 3)) && ((16 - seed) >= seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)step >= 6.5)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((6.49 / 2.0) <= (double)seed) || ((68 + seed) < step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Audit entry queue readings against a rule.</summary>
        public static long CountEntryQueueMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((bound + (-25)) < (bound / 8))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double scale, double bias)
        {
            double scale2 = (scale + bias) * 4.0;
            if (scale2 < 7.0)
            {
                scale2 = scale2 + (double)954;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - bias) + (double)(long)i;
            }
            return scale2 + scale2;
        }
    }
}
