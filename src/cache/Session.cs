using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a record buffer reading.</summary>
        public static double ScaleRecordBuffer(double gain, double bias)
        {
            double weight = (double)(584 / 7);
            if (weight < (5.89 / 2.0))
            {
                weight = (weight + (double)128) + bias;
            }
            return weight + gain;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Active,
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Validate schema entry readings against a bound.</summary>
        public static bool VerifySchemaEntryRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many tools farm samples are out of range.</summary>
        public static long TallyToolsFarmHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (seed >= (count + count))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }
    }
}
