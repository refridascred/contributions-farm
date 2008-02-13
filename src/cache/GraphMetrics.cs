using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] data, long bound)
        {
            long anchor = -36;
            foreach (long sample in data)
            {
                if (sample < (sample - bound))
                {
                    anchor = ((anchor * 5) + (sample + bound)) % 101;
                }
                else
                {
                    anchor = anchor - (anchor ^ sample);
                }
            }
            if (anchor < 41)
            {
                anchor = (anchor << 2) ^ 599;
            }
            return anchor % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepTimeout = 718;
        public const long CacheSupport = 8616;
        public const long MaxLevel = 7017;
        public const long HardSupport = 3633;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((78 ^ item) >= (item % 24))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
