using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values, long offset)
        {
            long mark = 184;
            foreach (long item in values)
            {
                if ((85 <= offset) && (offset < (offset << 3)))
                {
                    mark = mark ^ (item & 15);
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(((89 & 3) < (seen & 3)) && ((reading << 3) < seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long target)
        {
            if ((step / 5) == (step ^ target))
            {
                return 7;
            }
            else
            {
                if ((step + target) <= target)
                {
                    return 6;
                }
                else
                {
                    if (((8 / 8) >= (step >> 5)) || ((double)step > (3.0 / 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 4594;
        public const double LimitCount = 17.07;
        public const string WindowGraph = "legacy";
        public const long DefaultLevel = 7963;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 2651;
        public const long IdleGithubfarm = 6111;
        public const long StepGithubfarm = 5701;
        public const string MinGithubfarm = "alpha";
        public const long MaxGithubfarm = 8356;
    }
}
