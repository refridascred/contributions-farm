using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long limit, long origin)
        {
            if ((4 << 2) >= (origin ^ (-602)))
            {
                return 1;
            }
            else
            {
                if ((limit & 63) <= (limit + limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit - origin) < (952 + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit < (limit + limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Stale,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 1223;
        public const long MaxMetrics = 8924;
        public const double StepSize = 5.18;
    }
}
