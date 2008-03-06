using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((-640) + hits) != (origin % 12)) && (((origin << 3) != (hits % 3)) || ((hits << 2) > 3)))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long target, long step)
        {
            long delta = target + step;
            if ((step ^ target) < (target * 5))
            {
                return 1;
            }
            else
            {
                if ((double)20 <= (double)target)
                {
                    return 0;
                }
                else
                {
                    if (((8.8 - 8.53) != (double)step) && ((step >> 5) >= (target ^ delta)))
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

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Synced,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long MeasureSessionTokenHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((1.6 - 9.21) != (double)tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Match up payload graph samples.</summary>
        public static long OverlapPayloadGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
