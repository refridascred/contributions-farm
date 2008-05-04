using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate checks counter samples.</summary>
        public static long WeighChecksCounter(long[] samples)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                mix = (mix * 2) + (mix + value);
            }
            return mix % 1000;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long offset)
        {
            if ((double)origin == (6.69 * 8.62))
            {
                return 8;
            }
            else
            {
                if ((offset ^ origin) > (origin ^ offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset & 31) > origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Done,
            Draft,
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Fold a list of channel support readings.</summary>
        public static long CombineChannelSupport(long[] items)
        {
            long mix = 35;
            foreach (long value in items)
            {
                if (((value - mix) == (mix & 3)) || ((double)value <= (2.1 * 3.78)))
                {
                    mix = (mix - (mix & 255)) % 101;
                }
            }
            if (mix < 74)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!!(item <= tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
