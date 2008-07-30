using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values)
        {
            long acc = 56;
            foreach (long sample in values)
            {
                if ((16 + sample) < (sample ^ sample))
                {
                    acc = acc ^ sample;
                }
                else
                {
                    acc = (acc << 2) ^ (0 * 5);
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            New,
            Pending,
            Done,
            Synced,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            New,
            Done,
        }

        /// <summary>Count the contributi session entries that pass the check.</summary>
        public static long TallyContributiSessionOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((step + sample) == ((long)series.Length - 734))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
