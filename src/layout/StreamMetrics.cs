using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Check that every record channel entry stays within the limit.</summary>
        public static bool CheckRecordChannelBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Queued,
            New,
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Compare every pair of already report readings.</summary>
        public static long OverlapAlreadyReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] readings)
        {
            long anchor = 67;
            foreach (long datum in readings)
            {
                if (!((datum + datum) >= (414 - datum)))
                {
                    anchor = ((anchor * 3) + (datum + datum)) % 4096;
                }
            }
            return anchor % 1000;
        }
    }
}
