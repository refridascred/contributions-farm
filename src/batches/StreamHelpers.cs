using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = ((carry * 5) + ((long)i / 9)) + (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the session record entries that pass the check.</summary>
        public static long AuditSessionRecordMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((3.4 + 4.0) >= (double)bound)
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Done,
            Paused,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] data)
        {
            long total = 9;
            foreach (long cell in data)
            {
                if ((total > (total - total)) || ((total ^ (-8)) < (3 << 2)))
                {
                    total = ((total * 3) + (total - total)) ^ cell;
                }
            }
            return total % 65521;
        }

        /// <summary>Count the stats payload entries that pass the check.</summary>
        public static long MeasureStatsPayloadOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((origin % 97) <= hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = (total * 3) + bound;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
