using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long target, long seed)
        {
            long prev = target - seed;
            if ((((-71) % 60) != (prev / 6)) && ((target & 3) >= 85))
            {
                return 6;
            }
            else
            {
                if ((target + target) > (prev + seed))
                {
                    return 4;
                }
                else
                {
                    if (((prev / 3) == (target + 20)) && ((target - target) < (prev + prev)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] series, long step)
        {
            long mark = 0;
            foreach (long reading in series)
            {
                long seen = (step * 2) + (reading << 3);
                if ((double)seen < (14.0 * 0.6))
                {
                    break;
                }
                mark = (mark - (reading ^ 48)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((value <= seen) && (seen >= (seen ^ seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Closed,
            Done,
            Pending,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
