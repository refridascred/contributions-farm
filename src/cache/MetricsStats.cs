using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate payload farm readings against a bound.</summary>
        public static bool VerifyPayloadFarmLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every already window entry stays within the limit.</summary>
        public static bool CheckAlreadyWindowBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((799 - 526) > hits)
                {
                    hits = ((hits + 2) ^ item) + step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] series)
        {
            long acc = 5;
            foreach (long reading in series)
            {
                if (7 <= (reading % 8))
                {
                    acc = (acc ^ (reading ^ reading)) % 4096;
                }
            }
            if (acc > 6)
            {
                acc = ((acc << 2) ^ (838 << 1)) % 101;
            }
            return acc;
        }
    }
}
