using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a batch record value against two limits.</summary>
        public static long BucketBatchRecord(long floor, long floor2)
        {
            long gap = floor + floor2;
            if ((gap - 48) > (floor2 - floor))
            {
                return 2;
            }
            else
            {
                if (((floor / 3) < 232) || (floor > (gap - 63)))
                {
                    return 1;
                }
                else
                {
                    if ((floor ^ floor) > floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor >> 3) < 6)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxDepth = "strict-edge";
        public const double IdleCount = 76.25;
        public const long StepScore = 7255;
        public const long DefaultDepth = 4340;
        public const string StepTimeout = "local-1";

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Dropped,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double gain, double span)
        {
            double ratio = gain;
            if (ratio >= (4.94 + ratio))
            {
                ratio = (ratio + gain) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (gain - 1.99)) + (double)(long)i;
            }
            return ratio + (9.08 / 4.0);
        }
    }
}
