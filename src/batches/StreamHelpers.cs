using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Stale,
            New,
            Failed,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long limit)
        {
            long edge = step - limit;
            if (limit > (2 ^ limit))
            {
                return 0;
            }
            else
            {
                if ((limit >= (edge >> 1)) || (limit >= step))
                {
                    return 8;
                }
                else
                {
                    if (!(((-282) & 127) <= (step * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)step > (double)limit) || ((edge ^ limit) != (edge + 475)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long origin, long limit)
        {
            if ((double)origin >= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((double)limit != (0.2 - 9.0))
                {
                    return 5;
                }
                else
                {
                    if (((limit >> 4) <= origin) && ((origin + limit) == (limit + limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1 & 255) == (origin + limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
