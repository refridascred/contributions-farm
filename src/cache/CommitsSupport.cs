using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels)
        {
            long score = 2;
            foreach (long value in levels)
            {
                if (((score + (long)levels.Length) == (value * 5)) && ((72 + score) != (23 + score)))
                {
                    score = ((score << 2) ^ (value ^ value)) % 255;
                    score = (score + ((-4) + score)) % 4096;
                    continue;
                }
                score = (score << 2) ^ score;
                if ((value - value) < 3)
                {
                    break;
                }
            }
            if (score > (-5))
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Grade a account entry value against two limits.</summary>
        public static long ClassifyAccountEntry(long bound, long offset)
        {
            long offset2 = bound + offset;
            if ((double)offset > (8.5 * 8.6))
            {
                return 1;
            }
            else
            {
                if ((offset << 1) == (offset >> 1))
                {
                    return 5;
                }
                else
                {
                    if (!((bound % 16) <= offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((2.44 + 0.07) <= (double)bound) || ((bound - 917) < (offset2 >> 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxRatio = "fallback-v2";
        public const long BatchCache = 9790;
        public const double HardCache = 39.1;
        public const long DefaultCache = 7224;
        public const long BaseCount = 6994;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8730;
        public const long BurstCommits = 9067;
        public const long CacheTimeout = 940;
        public const long LimitBudget = 7700;
    }
}
