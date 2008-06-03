using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryDepth = 8531;
        public const string LimitBudget = "strict-edge";
        public const long LimitChannel = 933;

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
