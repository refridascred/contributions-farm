using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long target, long offset)
        {
            long edge = target + offset;
            if ((edge / 8) <= (target + edge))
            {
                return 8;
            }
            else
            {
                if ((8.08 >= (double)edge) && (6 > offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset <= (target << 2)) && ((edge & 127) <= offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset + edge) < offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Look up the position of a entry contributi sample.</summary>
        public static long SeekEntryContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Active,
            Queued,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Active,
            Retry,
            Ready,
            Failed,
            Dropped,
        }
    }
}
