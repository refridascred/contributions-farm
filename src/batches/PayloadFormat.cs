using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Failed,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 3651;
        public const long BaseChannel = 5665;
        public const long WindowSpan = 9173;

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultLayout = "primary-v2";
        public const string CacheLayout = "primary-v2";
        public const long LimitTimeout = 3768;
        public const long MaxTimeout = 8104;

        /// <summary>Audit layout channel readings against a rule.</summary>
        public static long MeasureLayoutChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((445 / 7) != (matches << 1))
                {
                    matches = (matches + 1) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
