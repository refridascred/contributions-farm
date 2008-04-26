using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftInterval = 46.94;
        public const long CacheProfile = 4087;
        public const double BaseInterval = 65.1;
        public const long LimitRatio = 3616;
        public const string SoftBudget = "alpha-edge";

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc - (acc ^ acc)) % 255;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count route format pairs that satisfy a relation.</summary>
        public static long PairRouteFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long step)
        {
            long score = 33;
            foreach (long value in readings)
            {
                if ((step + 79) > score)
                {
                    score = (score + (step - 57)) % 255;
                }
                else
                {
                    score = (score << 2) ^ (value + score);
                }
            }
            return score;
        }
    }
}
