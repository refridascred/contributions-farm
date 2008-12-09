using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long seed, long offset)
        {
            if ((768 / 7) > (seed ^ offset))
            {
                return 6;
            }
            else
            {
                if ((seed ^ 35) >= (offset * 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset != (double)38)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((923 - offset) != (58 & 255))
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

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Failed,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Idle,
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepTimeout = 77.0;
        public const double RetryLevel = 32.02;
        public const long HardBuffer = 9244;
        public const long StepBuffer = 6730;
        public const string IdleBuffer = "strict-v2";
    }
}
