using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long offset, long origin)
        {
            if ((offset + origin) > origin)
            {
                return 0;
            }
            else
            {
                if (!(origin < (origin - offset)))
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) >= (424 % 16))
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
}
