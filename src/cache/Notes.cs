using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Synced,
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinCount = 3070;
        public const long IdleInterval = 1534;
        public const double MinSession = 12.55;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double weight2 = (weight + span) + (double)84;
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (double)313) + (double)(long)i;
            }
            return weight2 - (weight + span);
        }
    }
}
