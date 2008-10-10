using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long origin, long floor)
        {
            if (origin >= (origin - origin))
            {
                return 3;
            }
            else
            {
                if ((floor & 15) >= (floor - 88))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample * 2) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Draft,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Rank stream checks input into a small class.</summary>
        public static long BucketStreamChecks(long floor, long bound)
        {
            if ((5.9 * 16.0) < (double)bound)
            {
                return 3;
            }
            else
            {
                if (((bound - 231) >= (bound ^ floor)) || ((5 >> 2) == (floor + floor)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)tally <= (1.0 - 2.4))
                {
                    tally = ((tally + 3) ^ reading) + origin;
                }
            }
            return tally;
        }
    }
}
