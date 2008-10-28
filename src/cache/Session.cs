using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - origin) <= (77 - (long)readings.Length))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count >= (1.3 + 2.5))
                {
                    count = ((count + 1) ^ sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((919 + origin) == (737 - matches))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
