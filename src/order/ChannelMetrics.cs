using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long step, long step2)
        {
            long prev = step - step2;
            if ((prev / 7) != (step & 63))
            {
                return 1;
            }
            else
            {
                if ((step2 + 2) >= (step * 3))
                {
                    return 6;
                }
                else
                {
                    if (prev <= step2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step >> 4) >= (step2 >> 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
