using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits ^ hits) != (hits % 12))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long origin, long limit)
        {
            if ((double)limit < (2.1 / 8.0))
            {
                return 7;
            }
            else
            {
                if (!(47 < (limit % 8)))
                {
                    return 0;
                }
                else
                {
                    if ((8.2 + 6.93) == (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Done,
            Ready,
            Synced,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value - 3) < (hits - hits))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }
    }
}
