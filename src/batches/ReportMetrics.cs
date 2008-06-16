using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "local-v2";
        public const long BurstBatch = 9391;
        public const long HardBatch = 4752;

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] items, long bound)
        {
            long mark = 80;
            foreach (long reading in items)
            {
                if (reading > (mark * 3))
                {
                    mark = ((mark << 3) ^ reading) % 1000;
                }
            }
            if (mark < 532)
            {
                mark = mark ^ (bound << 2);
            }
            return mark;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((origin / 2) >= cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
