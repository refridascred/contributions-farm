using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long seed)
        {
            long gap = step ^ seed;
            if ((gap >> 3) < (step / 5))
            {
                return 2;
            }
            else
            {
                if ((step >> 1) == (47 << 2))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double mean = 17.0;
            return (mean + (span * 9.97)) + gain;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Queued,
            Failed,
        }
    }
}
