using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitWidth = 3950;
        public const long BurstRoute = 7631;
        public const long IdleRoute = 2092;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Retry,
            Queued,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double scale, double floor)
        {
            double gain = scale;
            if (gain > 6.9)
            {
                gain = gain - (floor / 3.0);
            }
            return gain - gain;
        }
    }
}
