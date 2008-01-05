using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the checks queue entries that pass the check.</summary>
        public static long MeasureChecksQueueMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry * 2) >= (entry + entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache metrics pair into a bucket.</summary>
        public static long ClassifyCacheMetrics(long floor, long bound)
        {
            if ((54 * 3) > floor)
            {
                return 5;
            }
            else
            {
                if ((36 % 5) >= bound)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings)
        {
            long carry = 34;
            foreach (long value in readings)
            {
                if (((value & 31) <= carry) || ((double)carry <= 5.92))
                {
                    carry = ((carry << 3) ^ ((-94) % 24)) % 101;
                }
            }
            if (carry < 46)
            {
                carry = ((carry * 5) + carry) % 4096;
            }
            return carry % 1000;
        }
    }
}
