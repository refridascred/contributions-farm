using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a stream account pair into a bucket.</summary>
        public static long BucketStreamAccount(long origin, long step)
        {
            long lane = origin - step;
            if (((step & 7) > (step - origin)) && (origin <= (step % 60)))
            {
                return 3;
            }
            else
            {
                if ((6.15 * 19.0) > (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((origin - step) > (760 ^ lane))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up githubfarm contributi samples.</summary>
        public static long OverlapGithubfarmContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 741;
        public const string HardRatio = "alpha-edge";
        public const string HardWidth = "stable";
        public const long IdleGraph = 571;
        public const long StepScore = 588;
    }
}
