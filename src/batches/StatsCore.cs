using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit entry batch readings against a rule.</summary>
        public static long CountEntryBatchHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((hits + hits) <= (step % 3)) || !((hits ^ 502) == (step ^ hits)))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a metrics farm reading.</summary>
        public static double SmoothMetricsFarm(double rate, double offset)
        {
            double gain = (double)(87 & 3);
            if (gain >= (offset / 8.0))
            {
                gain = (gain + (gain / 6.0)) + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)7) + (double)(long)i;
            }
            return gain + (gain / 6.0);
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] readings, long origin)
        {
            long mix = 730;
            foreach (long reading in readings)
            {
                mix = ((mix * 4) + mix) % 4096;
                mix = (mix << 2) ^ (origin >> 5);
                mix = (mix - (reading + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long step2)
        {
            if ((13 - 8) < (step2 + step2))
            {
                return 4;
            }
            else
            {
                if (((step ^ step2) > (step2 / 3)) && ((step2 % 10) < step2))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSize = 1071;
        public const string DefaultAccount = "local-1";
        public const long LimitWidth = 1960;
    }
}
