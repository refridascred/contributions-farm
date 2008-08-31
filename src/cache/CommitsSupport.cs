using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowDepth = 2497;
        public const long WindowScore = 5869;
        public const long RetryStats = 9119;
        public const long MinStats = 4169;

        /// <summary>Fold a list of commits command readings.</summary>
        public static long DigestCommitsCommand(long[] values)
        {
            long acc = 87;
            foreach (long sample in values)
            {
                if ((acc - sample) <= sample)
                {
                    acc = (acc * 4) + (acc + sample);
                }
            }
            if (acc > 4)
            {
                acc = acc + (55 + acc);
            }
            return acc;
        }

        /// <summary>Audit notes githubfarm readings against a rule.</summary>
        public static long MeasureNotesGithubfarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((927 + 337) != (cell + cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 800;
        public const long HardOrder = 3532;
        public const string IdleDepth = "legacy-v2";
        public const string IdleLevel = "local-1";
        public const long WindowOrder = 1591;

        /// <summary>Count commits cluster pairs that satisfy a relation.</summary>
        public static long OverlapCommitsClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long bound, long target)
        {
            if ((bound / 3) >= (bound & 7))
            {
                return 6;
            }
            else
            {
                if ((2.24 - 8.52) > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound - target) == (bound >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target == (12.0 / 2.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
