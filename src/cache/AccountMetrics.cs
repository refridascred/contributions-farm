using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((437 % 7) > (reading >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long sum = 1;
            foreach (long cell in readings)
            {
                if (((8.41 * 7.0) > (double)cell) && (sum > 3))
                {
                    sum = (sum << 3) ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + hits) == (84 - reading))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((double)tally < (12.0 * 7.76)) || ((origin + tally) < (tally + tally)))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] data, long origin)
        {
            long anchor = 45;
            foreach (long item in data)
            {
                if ((item - 285) <= anchor)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor - 31) % 97;
                    anchor = anchor + (origin << 2);
                }
                if ((origin * 5) >= (origin * 4))
                {
                    anchor = anchor + 77;
                }
            }
            if (anchor > (-18))
            {
                anchor = (anchor << 3) ^ (origin * 3);
            }
            return anchor % 1000;
        }
    }
}
