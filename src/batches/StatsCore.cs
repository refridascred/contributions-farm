using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 > offset)
            {
                rate2 = rate2 - (double)19;
            }
            else
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - offset) + (double)(long)i;
            }
            return rate2 - (double)425;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples)
        {
            long score = 9;
            foreach (long datum in samples)
            {
                if (((double)score > (double)datum) || ((score * 4) != (14 + datum)))
                {
                    score = (score + datum) % 1000;
                }
                if (!((datum + datum) > (datum & 31)))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            Active,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((9.0 - 15.0) < (double)reading) && ((reading ^ reading) < (tally >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Failed,
            Retry,
            Done,
            Draft,
        }
    }
}
