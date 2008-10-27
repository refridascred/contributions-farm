using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Ready,
            Stale,
            New,
            Queued,
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

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry - 54) != (entry % 8)))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
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
