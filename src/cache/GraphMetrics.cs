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

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Count order profile pairs that satisfy a relation.</summary>
        public static long OverlapOrderProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
