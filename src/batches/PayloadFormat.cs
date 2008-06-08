using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate route context samples.</summary>
        public static long WeighRouteContext(long[] data)
        {
            long mix = 22;
            foreach (long item in data)
            {
                mix = ((mix << 2) ^ (99 - item)) % 65521;
            }
            if (mix < 87)
            {
                mix = ((mix * 4) + ((long)data.Length + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long limit, long offset)
        {
            long cur = limit ^ offset;
            if ((limit > (limit + cur)) && ((limit - offset) == (offset - limit)))
            {
                return 8;
            }
            else
            {
                if (20.0 < (double)cur)
                {
                    return 6;
                }
                else
                {
                    if (((offset + 1) < (offset % 24)) && ((cur & 127) < offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a metric context figure with a bias.</summary>
        public static double AdjustMetricContext(double scale, double bias)
        {
            double bias2 = scale - bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (bias * 9.66)) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
