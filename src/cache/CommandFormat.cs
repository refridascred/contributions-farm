using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values)
        {
            long score = -7;
            foreach (long cell in values)
            {
                if (!((double)score >= (8.0 + 6.0)))
                {
                    score = score + (score % 8);
                }
                if (!((score + cell) < cell))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long target, long bound)
        {
            if ((bound >= (bound + target)) && ((6.2 + 20.0) != (double)bound))
            {
                return 8;
            }
            else
            {
                if ((bound * 4) <= target)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of commits record entries.</summary>
        public static long DigestCommitsRecord(long[] readings, long bound)
        {
            long total = 8;
            foreach (long sample in readings)
            {
                total = ((total + ((long)readings.Length - 33)) % 255) + sample;
                total = (total << 2) ^ (91 * 2);
            }
            if (total > 478)
            {
                total = (total + (bound - bound)) % 4096;
            }
            return total % 1000;
        }
    }
}
