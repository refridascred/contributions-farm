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

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
