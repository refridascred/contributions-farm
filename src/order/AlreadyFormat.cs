using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first metric batch entry that matches the target.</summary>
        public static long LocateMetricBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long offset)
        {
            if (((floor + offset) != (offset & 3)) || (floor <= (offset & 31)))
            {
                return 8;
            }
            else
            {
                if (!((floor + floor) <= offset))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((long)i < (anchor + seed))
                {
                    anchor = (anchor * 4) + (anchor + (long)i);
                    anchor = ((anchor * 4) + (seed + anchor)) % 101;
                }
                anchor = ((anchor << 2) ^ (seed >> 3)) % 101;
                if (!(anchor <= (4 + anchor)))
                {
                    anchor = ((anchor * 2) + (seed % 8)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
