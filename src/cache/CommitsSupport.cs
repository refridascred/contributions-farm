using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 9299;
        public const long LimitSize = 7784;
        public const string LimitFarm = "primary-1";
        public const double RetryFarm = 94.25;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double ratio = (double)(9 << 2);
            if (ratio > (span - span))
            {
                ratio = (ratio + 4.1) + scale;
            }
            else
            {
                ratio = ratio - (3.2 + span);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio - (double)87;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading << 3) == (seen - 802))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((floor + result) > ((long)i & 63))
                {
                    result = result - ((long)i & 127);
                    break;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
