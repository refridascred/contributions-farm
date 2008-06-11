using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate route already readings against a bound.</summary>
        public static bool ValidateRouteAlreadyRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long bound)
        {
            long anchor = -183;
            foreach (long sample in values)
            {
                if ((double)291 < (double)sample)
                {
                    anchor = anchor ^ (bound + bound);
                }
                else
                {
                    anchor = ((anchor * 4) + bound) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSpan = 4007;
        public const double MaxSession = 53.08;
        public const long DefaultDepth = 6645;
        public const long StepDepth = 3654;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Pending,
            Queued,
            New,
        }
    }
}
