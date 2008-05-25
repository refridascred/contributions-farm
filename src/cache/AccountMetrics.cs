using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long step)
        {
            long mix = 221;
            foreach (long entry in readings)
            {
                mix = ((mix << 2) ^ entry) - step;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftWidth = 42.03;
        public const long BurstAlready = 843;
        public const long DefaultInterval = 5617;
        public const long HardCount = 380;

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((double)seed == (double)score)
                {
                    score = (score ^ (long)i) % 255;
                    continue;
                }
                long prev = score ^ score;
                score = (score + (prev - 14)) % 97;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long floor)
        {
            long next = bound ^ floor;
            if ((next + bound) == (floor & 255))
            {
                return 7;
            }
            else
            {
                if (((double)95 != (double)bound) || ((bound + 125) >= bound))
                {
                    return 5;
                }
                else
                {
                    if ((0.9 - 5.8) != (double)next)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound - 0) != (42 - next))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
