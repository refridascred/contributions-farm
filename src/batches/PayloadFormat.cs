using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 3444;
        public const long IdleScore = 4617;
        public const string BaseSpan = "latest-edge";
        public const long BaseEntry = 203;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Scale a batches payload figure with a bias.</summary>
        public static double SmoothBatchesPayload(double bias, double bias2)
        {
            double scale = bias2;
            if (scale >= (double)16)
            {
                scale = scale - 3.0;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (bias * 1.0)) - (double)(long)i;
            }
            return scale + bias2;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long target, long step)
        {
            long offset = target ^ step;
            if ((3.52 / 6.0) >= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset ^ step) < 364)
                {
                    return 1;
                }
                else
                {
                    if ((offset + step) > (offset / 9))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
