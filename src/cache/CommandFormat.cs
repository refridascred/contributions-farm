using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate profile contributi samples.</summary>
        public static long TotalProfileContributi(long[] series, long limit)
        {
            long acc = 782;
            foreach (long item in series)
            {
                if ((limit << 1) != (acc - acc))
                {
                    acc = (acc << 3) ^ (item * 5);
                }
            }
            if (acc > 9)
            {
                acc = (acc + (234 - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Failed,
            Closed,
            Queued,
            Done,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((double)item <= (2.4 + 9.8)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
