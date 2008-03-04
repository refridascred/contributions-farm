using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item > (72 & 1)) || ((tally * 3) < (item + item)))
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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= (7 << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] series, long target)
        {
            long total = 40;
            foreach (long datum in series)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (((total * 3) + 925) - (long)i2) ^ datum;
                }
                if ((15.0 + 5.02) != (double)total)
                {
                    total = (total - (total - total)) % 1000;
                }
            }
            if (total < 7)
            {
                total = ((total << 2) ^ (target + target)) % 97;
            }
            return total;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            Closed,
            Stale,
            Idle,
            Paused,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((((7.5 - 9.0) >= (double)datum) || ((double)datum > (2.3 / 7.0))) || !((double)datum < 3.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
