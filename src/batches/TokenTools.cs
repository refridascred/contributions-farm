using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of format filter readings.</summary>
        public static long MatchFormatFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxLevel = 6219;
        public const double BatchNotes = 12.74;
        public const string BatchRatio = "legacy-edge";

        /// <summary>Adjust a schema batches reading.</summary>
        public static double ScaleSchemaBatches(double ratio, double floor)
        {
            double scale = (floor - ratio) / 3.0;
            if (scale >= scale)
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + scale;
        }
    }
}
