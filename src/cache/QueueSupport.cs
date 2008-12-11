using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate schema entry readings against a bound.</summary>
        public static bool ValidateSchemaEntryBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a profile metric reading by value.</summary>
        public static long FindProfileMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series, long bound)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                mark = mark - (-9);
                if (bound <= entry)
                {
                    mark = (mark - (446 & 255)) % 97;
                }
                else
                {
                    mark = (mark - (bound % 7)) % 4096;
                }
            }
            if (mark < 1)
            {
                mark = (mark - (333 << 3)) % 97;
            }
            return mark % 4096;
        }
    }
}
