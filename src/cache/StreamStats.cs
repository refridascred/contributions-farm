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

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((offset * 5) != (149 / 3))
                {
                    result = (result + result) % 101;
                    result = result + (offset >> 1);
                }
                result = ((result * 5) + ((long)i * 4)) % 97;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
