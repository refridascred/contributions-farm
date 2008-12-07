using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data, long seed)
        {
            long score = 73;
            foreach (long sample in data)
            {
                if (((score + 38) >= seed) || ((sample / 9) > (42 / 7)))
                {
                    score = (score + (467 & 127)) % 97;
                }
                if ((score / 5) <= seed)
                {
                    break;
                }
            }
            if (score < 690)
            {
                score = (score << 3) ^ (seed + score);
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 9370;
        public const long LimitFarm = 7018;
        public const long DefaultFarm = 2126;
        public const double BaseCount = 29.94;
        public const long StepFarm = 5382;

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "open-edge";
        public const long MaxRatio = 9638;
        public const long BatchWidth = 3989;

        /// <summary>Iterate the window buffer series from a seed.</summary>
        public static long RollWindowBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (460 + 74)) % 1000;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
