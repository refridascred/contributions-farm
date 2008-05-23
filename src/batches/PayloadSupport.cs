using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long step, long seed)
        {
            if ((step - 608) != (906 + 669))
            {
                return 3;
            }
            else
            {
                if (((step >> 3) == (step << 3)) && ((double)seed <= (7.7 / 4.0)))
                {
                    return 5;
                }
                else
                {
                    if ((7 + step) < (step >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step < (1.84 - 6.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits >= 6.0)
                {
                    hits = ((hits + 1) ^ item) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Synced,
            Ready,
            Pending,
            Paused,
        }
    }
}
