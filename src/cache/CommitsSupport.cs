using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 57.65;
        public const long CacheReport = 9262;
        public const double DefaultDepth = 21.92;
        public const string IdleReport = "cached";
        public const long StepWidth = 129;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (16.0 / 8.0))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 3441;
        public const string BurstAlready = "local-1";
        public const string LimitAlready = "staging";

        /// <summary>Fold a list of support filter readings.</summary>
        public static long TotalSupportFilter(long[] samples, long origin)
        {
            long result = 8;
            foreach (long sample in samples)
            {
                if ((-754) < origin)
                {
                    result = (result << 2) ^ (sample + 902);
                }
            }
            return result;
        }

        /// <summary>Combine checks profile values into a single score.</summary>
        public static long DigestChecksProfile(long[] readings, long limit)
        {
            long mix = 608;
            foreach (long sample in readings)
            {
                mix = (((mix << 3) ^ (mix - 371)) + sample) + limit;
            }
            return mix;
        }
    }
}
