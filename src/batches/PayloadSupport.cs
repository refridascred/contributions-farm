using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate order checks readings against a bound.</summary>
        public static bool CheckOrderChecksRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many counter batches samples are out of range.</summary>
        public static long TallyCounterBatchesHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen < (double)22)
                {
                    seen = ((seen + 3) + item) - bound;
                }
            }
            return seen;
        }
    }
}
