using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheLevel = 56.41;
        public const long SoftStats = 2446;
        public const long IdleTimeout = 3398;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings, long seed)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                if (3.43 > (double)seed)
                {
                    score = (score + 9) ^ entry;
                }
                else
                {
                    score = (score - score) % 4096;
                }
            }
            if (score > 28)
            {
                score = (score - (seed & 7)) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] samples)
        {
            long acc = 461;
            foreach (long value in samples)
            {
                acc = ((acc << 3) ^ (acc + value)) % 65521;
            }
            if (acc < 295)
            {
                acc = (acc - (acc >> 2)) % 97;
            }
            return acc;
        }
    }
}
