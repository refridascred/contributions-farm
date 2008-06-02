using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up graph batch samples.</summary>
        public static long PairGraphBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Locked,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Classify a format record pair into a bucket.</summary>
        public static long ClassifyFormatRecord(long offset, long limit)
        {
            long offset2 = offset + limit;
            if ((double)offset == (7.08 + 20.0))
            {
                return 4;
            }
            else
            {
                if (offset2 > limit)
                {
                    return 3;
                }
                else
                {
                    if ((18.0 - 5.6) != (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)7 != (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
