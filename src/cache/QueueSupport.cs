using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Dropped,
            Paused,
            Active,
            Pending,
        }

        /// <summary>Grade a stats batch value against two limits.</summary>
        public static long BucketStatsBatch(long step, long limit)
        {
            if ((step - 761) == (6 - step))
            {
                return 3;
            }
            else
            {
                if (!((step * 4) < (limit % 97)))
                {
                    return 6;
                }
                else
                {
                    if (((-231) + limit) > (limit - 85))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) > ((-8) - limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Pending,
            Failed,
            Closed,
        }
    }
}
