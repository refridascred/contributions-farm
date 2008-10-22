using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long seed)
        {
            long next = offset ^ seed;
            if ((seed + offset) > seed)
            {
                return 4;
            }
            else
            {
                if ((seed * 4) < (seed + next))
                {
                    return 7;
                }
                else
                {
                    if ((11.0 - 14.0) > (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset % 7) <= (seed * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token report readings against a rule.</summary>
        public static long AuditTokenReportOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (8.25 < (double)hits)
                {
                    hits = ((hits + 3) + item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples, long target)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                if (mark > (datum + datum))
                {
                    mark = (((mark * 2) + (83 + 659)) % 101) - target;
                }
            }
            return mark % 4096;
        }
    }
}
