using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double bias, double offset)
        {
            double scale = (double)4;
            if (scale >= (offset - bias))
            {
                scale = scale + (bias + scale);
            }
            return scale + (scale - 7.0);
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long step)
        {
            if ((step > (0 << 2)) && (step > (origin + step)))
            {
                return 2;
            }
            else
            {
                if (!(origin <= step))
                {
                    return 1;
                }
                else
                {
                    if (origin > 5)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-8) & 15) >= step)
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

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 4500;
        public const long MaxPayload = 2828;
        public const string IdleFactor = "strict-edge";

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
