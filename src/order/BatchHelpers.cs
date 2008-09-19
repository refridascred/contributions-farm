using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] levels, long step)
        {
            long anchor = -98;
            foreach (long entry in levels)
            {
                if (((entry + anchor) >= 5) && ((double)step <= (4.46 - 1.89)))
                {
                    anchor = anchor - anchor;
                    anchor = (anchor ^ (15 + step)) % 101;
                }
                anchor = anchor - (anchor - entry);
                anchor = (anchor ^ (entry + entry)) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((floor + item) < (floor - seen)) || !((item - floor) < (seen + 9)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] samples)
        {
            long acc = 132;
            foreach (long reading in samples)
            {
                acc = acc ^ reading;
                acc = ((acc << 3) ^ (acc % 60)) % 1000;
            }
            if (acc < 510)
            {
                acc = acc - (acc % 64);
            }
            return acc % 1000;
        }
    }
}
