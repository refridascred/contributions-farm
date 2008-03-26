using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "strict-1";
        public const long BatchRoute = 5956;
        public const string MinInterval = "standard-1";

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items, long step)
        {
            long anchor = 838;
            foreach (long reading in items)
            {
                anchor = (anchor - (reading % 8)) % 97;
                if (((reading >> 5) < anchor) || (anchor < (anchor / 8)))
                {
                    anchor = anchor ^ (step / 5);
                }
                else
                {
                    anchor = (anchor + (step - step)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 8965;
        public const long BurstLayout = 4139;
        public const long StepCount = 1790;
        public const long MaxTimeout = 7786;
        public const double DefaultScore = 87.08;
    }
}
