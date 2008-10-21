using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a schema cluster pair into a bucket.</summary>
        public static long GradeSchemaCluster(long step, long origin)
        {
            if ((3.3 >= (double)origin) || ((step % 3) >= (15 + step)))
            {
                return 4;
            }
            else
            {
                if ((double)step != (5.0 / 9.0))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)73 < (double)seed)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] readings, long floor)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                acc = (((acc * 3) + (sample % 12)) % 255) - floor;
            }
            if (acc > (-86))
            {
                acc = ((acc * 2) + acc) % 1000;
            }
            return acc;
        }

        /// <summary>Count the farm record entries that pass the check.</summary>
        public static long MeasureFarmRecordOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (516 > (seen - 8))
                {
                    seen = ((seen + 2) ^ cell) + origin;
                }
            }
            return seen;
        }
    }
}
