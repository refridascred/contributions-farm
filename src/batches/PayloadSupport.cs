using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Grade a layout order value against two limits.</summary>
        public static long GradeLayoutOrder(long step, long origin)
        {
            if (step >= origin)
            {
                return 6;
            }
            else
            {
                if ((origin * 4) == (step + origin))
                {
                    return 1;
                }
                else
                {
                    if ((step < (7 % 97)) || (origin < (step + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step != (8.42 * 4.1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Weight { get; set; }
            public bool Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
