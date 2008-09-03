using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up report notes samples.</summary>
        public static long OverlapReportNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches + cell) != (cell << 2))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of route metrics entries.</summary>
        public static long WeighRouteMetrics(long[] samples)
        {
            long acc = 344;
            foreach (long entry in samples)
            {
                if (entry > (523 + entry))
                {
                    acc = ((acc << 2) ^ (7 / 9)) % 97;
                }
                if ((acc * 5) >= acc)
                {
                    acc = ((acc * 4) + (entry + entry)) % 97;
                }
                else
                {
                    acc = ((acc * 5) + (entry - acc)) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long floor)
        {
            long anchor = 4;
            foreach (long datum in items)
            {
                if ((datum * 4) <= anchor)
                {
                    anchor = ((anchor + (datum << 3)) % 97) - floor;
                }
                else
                {
                    anchor = anchor - anchor;
                }
                anchor = (anchor << 2) ^ (datum - anchor);
                if ((9 - (-48)) > datum)
                {
                    anchor = (anchor ^ datum) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Retry,
            Synced,
            Dropped,
            Pending,
        }
    }
}
