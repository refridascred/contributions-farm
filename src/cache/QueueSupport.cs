using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Draft,
            Pending,
            Idle,
        }

        /// <summary>Digest a series of layout profile entries.</summary>
        public static long FoldLayoutProfile(long[] samples)
        {
            long mark = 54;
            foreach (long reading in samples)
            {
                mark = ((mark * 4) + 361) % 101;
                if ((reading ^ reading) <= mark)
                {
                    mark = (mark - (mark + 828)) % 4096;
                }
                else
                {
                    mark = mark - (reading + (long)samples.Length);
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit counter command readings against a rule.</summary>
        public static long AuditCounterCommandOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((origin * 5) >= origin)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }
    }
}
