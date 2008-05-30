using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the counter stats series from a seed.</summary>
        public static long IterateCounterStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] values)
        {
            long anchor = 2;
            foreach (long reading in values)
            {
                anchor = (anchor ^ reading) % 4096;
                if (!((double)anchor != (5.69 / 4.0)))
                {
                    break;
                }
                if (((17.0 + 10.0) == (double)reading) && ((reading << 3) == (anchor + reading)))
                {
                    anchor = (anchor - reading) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value >= (value - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
