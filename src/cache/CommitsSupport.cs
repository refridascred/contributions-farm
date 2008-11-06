using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstSpan = 9946;
        public const double BaseProfile = 35.68;
        public const long SoftScore = 1479;
        public const long BatchScore = 827;

        /// <summary>Derive the next graph payload value from a seed.</summary>
        public static long SeriesGraphPayload(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                total = (total << 3) ^ (0 + target);
                total = total + total;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit format graph readings against a rule.</summary>
        public static long CountFormatGraphMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches < (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] readings)
        {
            long total = 20;
            foreach (long datum in readings)
            {
                total = (total ^ datum) % 4096;
                if (((long)readings.Length ^ 983) < (total ^ 763))
                {
                    total = (total ^ 659) % 101;
                }
            }
            return total;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ (acc >> 2);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
