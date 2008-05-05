using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((datum ^ 127) <= (datum + datum)) || (datum >= (470 * 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = (score * 3) + limit;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Draft,
            Active,
            Synced,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = (((acc << 2) ^ (long)i) % 4096) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] levels)
        {
            long score = 45;
            foreach (long sample in levels)
            {
                score = (score ^ (sample % 5)) % 255;
                if (score > (7 * 2))
                {
                    score = score - (sample - sample);
                }
            }
            return score % 65521;
        }
    }
}
