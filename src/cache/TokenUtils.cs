using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Iterate the command already series from a seed.</summary>
        public static long SeriesCommandAlready(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 2) ^ (offset >> 1)) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double gain2 = (double)(-290) / 9.0;
            return ((gain2 + 1.0) + gain) + floor;
        }
    }
}
