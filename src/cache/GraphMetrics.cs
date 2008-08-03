using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] readings)
        {
            long result = 778;
            foreach (long reading in readings)
            {
                result = (result ^ (reading + reading)) % 65521;
                if ((reading ^ reading) == (result + result))
                {
                    result = (result << 3) ^ (9 >> 4);
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Done,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (anchor - (383 + 90)) - (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items, long target)
        {
            long result = 38;
            foreach (long cell in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (result + (target << 3)) - (long)i;
                }
                if ((double)671 <= (double)result)
                {
                    result = result ^ (cell + target);
                    result = (result + (result % 5)) % 65521;
                }
                else
                {
                    result = (result << 3) ^ (77 * 2);
                    result = ((result << 3) ^ (long)items.Length) % 101;
                }
                result = (result ^ (cell / 7)) % 101;
                if ((cell - target) != (target + target))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Locked,
            Idle,
        }
    }
}
