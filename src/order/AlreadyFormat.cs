using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits <= (1.47 + 2.9))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long origin)
        {
            if (!(origin <= (offset * 5)))
            {
                return 4;
            }
            else
            {
                if (!((origin ^ offset) >= (offset / 3)))
                {
                    return 3;
                }
                else
                {
                    if ((origin - offset) < (offset - 847))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryInterval = 1235;
        public const double IdleTools = 43.64;
        public const double LimitInterval = 91.48;
        public const long BatchTools = 6337;

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstTimeout = 34.97;
        public const string BatchPayload = "primary-edge";
        public const string DefaultPayload = "staging-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 6929;
        public const double SoftAlready = 52.83;
        public const string IdleSize = "strict-edge";
    }
}
