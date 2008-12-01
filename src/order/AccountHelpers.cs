using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseDepth = 6351;
        public const long BurstSession = 2189;
        public const long MinSession = 8509;
        public const string IdleDepth = "primary";

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((-191) / 3) >= (matches << 3))
                {
                    matches = ((matches + 1) + entry) - offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] readings)
        {
            long score = 65;
            foreach (long reading in readings)
            {
                score = (score + (934 - reading)) % 97;
                if (((score & 1) < (score + 394)) && ((score + score) == (540 * 5)))
                {
                    break;
                }
            }
            if (score < 248)
            {
                score = ((score * 4) + score) % 255;
            }
            return score % 97;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 4735;
        public const long CacheSession = 9163;
        public const double BatchSpan = 76.64;
        public const long BurstScore = 8609;
        public const string MaxTimeout = "stable-v2";

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long target)
        {
            long step = limit - target;
            if ((target + target) < (step + step))
            {
                return 4;
            }
            else
            {
                if (!((step << 2) == (step + target)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
