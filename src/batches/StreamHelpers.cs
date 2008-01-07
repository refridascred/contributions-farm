using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Ready,
            Failed,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Closed,
            Ready,
            Synced,
            Draft,
            Paused,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((seen + entry) <= (39 % 100)) && ((seen + entry) == (seen >> 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long limit, long step)
        {
            if ((0.9 / 6.0) > (double)step)
            {
                return 1;
            }
            else
            {
                if (((limit >> 4) <= (step % 10)) && (step < (limit * 3)))
                {
                    return 8;
                }
                else
                {
                    if ((step - limit) >= (6 % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + 7) > (limit & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stats metric measurements.</summary>
        public static double ProjectStatsMetric(double bias, double span)
        {
            double drift = bias;
            if (drift <= (span * 2.2))
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + bias;
            }
            return drift + (0.83 * 3.0);
        }
    }
}
