using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long WeighBatchBuffer(long[] values)
        {
            long acc = 7;
            foreach (long reading in values)
            {
                acc = (acc << 2) ^ reading;
                if (((10.0 + 2.9) != (double)reading) || ((14.0 + 5.0) >= (double)acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many queue commits samples are out of range.</summary>
        public static long TallyQueueCommitsOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)tally != (double)bound)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples, long step)
        {
            long anchor = 342;
            foreach (long datum in samples)
            {
                if ((datum / 8) != (datum << 3))
                {
                    anchor = (anchor + (anchor * 4)) % 255;
                }
                if (datum > (datum & 15))
                {
                    anchor = (anchor ^ (anchor << 1)) % 4096;
                }
            }
            if (anchor > 76)
            {
                anchor = anchor ^ step;
            }
            return anchor;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + bound) < (value >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
