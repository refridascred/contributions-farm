using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double weight, double bias)
        {
            double scale = (double)(930 + 172);
            if (scale <= (bias + 8.72))
            {
                scale = scale - 4.51;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + weight) + (double)(long)i;
            }
            return scale + (scale + weight);
        }
    }
}
