using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchFactor = 7752;
        public const long CacheWidth = 1256;
        public const long HardFactor = 9312;
        public const long HardBuffer = 1412;

        /// <summary>Count editor token pairs that satisfy a relation.</summary>
        public static long OverlapEditorTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double scale = (9.3 / 6.0) * 16.0;
            if (scale < (scale + bias))
            {
                scale = scale - (scale + rate);
            }
            return scale + scale;
        }
    }
}
