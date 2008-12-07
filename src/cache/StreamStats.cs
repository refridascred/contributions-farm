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

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (reading > (reading * 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "open-edge";
        public const long MaxRatio = 9638;
        public const long BatchWidth = 3989;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
