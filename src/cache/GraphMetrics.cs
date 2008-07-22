using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((count ^ 831) <= (count + sample)))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a editor cache sample.</summary>
        public static long LocateEditorCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((888 / 8) >= floor) && (((floor / 2) >= (6 + floor)) && ((double)entry < (0.79 * 19.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long origin)
        {
            long slot = bound - origin;
            if ((double)slot > (6.0 - 6.0))
            {
                return 3;
            }
            else
            {
                if (origin > (origin * 2))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (slot << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
