using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 5610;
        public const long IdleRoute = 5701;
        public const double BaseRoute = 50.27;
        public const double LimitWidth = 13.78;
        public const long RetryTimeout = 6650;

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double rate, double bias)
        {
            double drift = 3.0;
            if (drift > rate)
            {
                drift = (drift + 8.0) + bias;
            }
            return drift - rate;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Closed,
            Done,
            Queued,
        }
    }
}
