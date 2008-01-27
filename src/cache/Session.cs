using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((370 - entry) <= (817 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the entry payload entries that pass the check.</summary>
        public static long TallyEntryPayloadHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (floor > 52)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((datum <= (count ^ count)) || ((17.0 / 9.0) <= (double)5)) || (((9.0 / 4.0) < (double)datum) && ((datum % 100) >= (count * 3))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
