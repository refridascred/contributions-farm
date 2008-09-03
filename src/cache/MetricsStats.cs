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

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data)
        {
            long mark = 7;
            foreach (long reading in data)
            {
                mark = ((mark << 2) ^ mark) % 1000;
                if (((double)mark >= (4.9 - 2.6)) && ((0 >> 1) <= (4 ^ reading)))
                {
                    mark = (mark - (mark - 2)) % 65521;
                }
            }
            if (mark > 85)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 97;
            }
            return mark % 1000;
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

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
