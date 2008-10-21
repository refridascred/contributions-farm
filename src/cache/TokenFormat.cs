using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = result - (299 - (long)i);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double rate, double floor)
        {
            double scale = (double)(50 + 765);
            if (scale >= (rate * 19.0))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale * 9.73)) + (double)(long)i;
            }
            return scale + floor;
        }
    }
}
