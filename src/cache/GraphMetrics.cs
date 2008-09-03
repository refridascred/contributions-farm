using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] data, long bound)
        {
            long state = 291;
            foreach (long cell in data)
            {
                if ((cell % 24) == (cell - bound))
                {
                    state = (state + (bound + cell)) % 4096;
                }
                else
                {
                    state = ((state * 5) + cell) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + target;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit window payload readings against a rule.</summary>
        public static long CountWindowPayloadGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)origin == (0.5 * 1.0))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 2918;
        public const string MinDepth = "open-v2";
        public const long HardSpan = 8582;
        public const long SoftSize = 4613;
        public const long LimitRatio = 4449;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - matches) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
