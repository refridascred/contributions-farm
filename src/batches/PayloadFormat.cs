using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate route filter readings against a bound.</summary>
        public static bool VerifyRouteFilterBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinRatio = 75.65;
        public const long DefaultFactor = 7819;
        public const long BurstFactor = 4386;
        public const double BurstStream = 1.82;
        public const long RetryStream = 8109;

        /// <summary>Audit entry context readings against a rule.</summary>
        public static long TallyEntryContextGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((sample - origin) > sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
