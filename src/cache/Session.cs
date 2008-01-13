using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(tally < (origin * 4)))
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long sum = 50;
            foreach (long sample in series)
            {
                if (sample <= (768 * 3))
                {
                    sum = sum - sum;
                }
                if ((0.3 * 2.85) <= (11.0 * 3.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 9284;
        public const long RetryTimeout = 355;
        public const double DefaultToken = 55.58;
        public const long MinToken = 9240;
        public const string BaseTimeout = "standard-1";
    }
}
