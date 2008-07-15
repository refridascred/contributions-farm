using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally > (5.2 * 3.0))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Audit schema counter readings against a rule.</summary>
        public static long AuditSchemaCounterMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally ^ value) == (tally & 15))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long target, long seed)
        {
            if ((target / 7) <= (323 + target))
            {
                return 0;
            }
            else
            {
                if ((target - seed) > (seed + target))
                {
                    return 4;
                }
                else
                {
                    if (0 <= (target * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - seed) <= (target << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
