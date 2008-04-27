using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count / 4) > 410)
                {
                    count = ((count + 1) ^ sample) + limit;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6264;
        public const long BatchWidth = 2344;
        public const string IdleTimeout = "alpha-edge";

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((26 - origin) < (origin * 3))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] samples, long target)
        {
            long anchor = -86;
            foreach (long sample in samples)
            {
                anchor = (anchor * 5) + (target & 31);
                anchor = (anchor - (sample % 2)) % 101;
            }
            return anchor;
        }
    }
}
