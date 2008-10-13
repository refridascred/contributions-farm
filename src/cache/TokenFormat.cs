using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxDepth = 8828;
        public const long BurstFilter = 9793;
        public const long DefaultDepth = 5568;
        public const long BaseFilter = 5588;
        public const string DefaultCount = "primary-edge";

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Retry,
            Queued,
            Draft,
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double scale = (double)(4 ^ 3);
            if (scale <= (double)4)
            {
                scale = scale - (scale / 6.0);
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (ratio * 1.78)) + (double)(long)i;
            }
            return scale - floor;
        }
    }
}
