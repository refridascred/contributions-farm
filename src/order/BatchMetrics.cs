using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two notes token measurements.</summary>
        public static double ProjectNotesToken(double weight, double span)
        {
            double rate = weight;
            if (rate >= (weight * 7.7))
            {
                rate = (rate - 9.33) + span;
            }
            return rate - 9.7;
        }

        /// <summary>Grade a buffer tools value against two limits.</summary>
        public static long SortBufferTools(long origin, long limit)
        {
            if (((origin % 100) <= (limit - limit)) || ((542 >> 4) <= origin))
            {
                return 7;
            }
            else
            {
                if ((676 % 60) < origin)
                {
                    return 3;
                }
                else
                {
                    if (!((double)origin < 0.9))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin >> 1) > (origin + origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 22.92;
        public const long StepCommand = 9457;
        public const long BaseFactor = 8864;
        public const long SoftSpan = 9852;
    }
}
