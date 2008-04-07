using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the payload farm entries that pass the check.</summary>
        public static long AuditPayloadFarmGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (744 <= seed)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream layout sample.</summary>
        public static long LocateStreamLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits layout input into a small class.</summary>
        public static long BucketCommitsLayout(long floor, long origin)
        {
            if ((origin << 3) == (floor + 621))
            {
                return 4;
            }
            else
            {
                if (floor > (floor >> 2))
                {
                    return 8;
                }
                else
                {
                    if (!((double)floor <= (16.0 - 7.6)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((origin - floor) <= floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
