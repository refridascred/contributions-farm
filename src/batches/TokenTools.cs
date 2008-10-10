using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "standard-1";
        public const double SoftInterval = 27.12;
        public const long BatchCluster = 2969;

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 > (span + span))
            {
                rate2 = rate2 + rate2;
            }
            return rate2 - rate;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}
