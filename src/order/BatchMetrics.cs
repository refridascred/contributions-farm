using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long floor)
        {
            long edge = origin + floor;
            if (!((floor % 12) <= (floor - edge)))
            {
                return 3;
            }
            else
            {
                if (20 < edge)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
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

        /// <summary>Blend two buffer layout measurements.</summary>
        public static double ScaleBufferLayout(double scale, double span)
        {
            double rate = 1.21;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + scale) - (double)(long)i) - span;
            }
            return rate - scale;
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
