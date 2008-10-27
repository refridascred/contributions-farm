using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((floor % 16) >= 9)
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = total ^ (total + origin);
                if (((7.1 - 7.0) < (double)total) || ((double)origin < 8.16))
                {
                    total = (total << 3) ^ (origin ^ 118);
                }
                total = (total << 2) ^ ((long)i * 2);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long floor, long origin)
        {
            if (!((double)floor < (3.9 - 2.5)))
            {
                return 5;
            }
            else
            {
                if ((origin + floor) == (floor >> 4))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Locked,
            New,
            Ready,
        }
    }
}
