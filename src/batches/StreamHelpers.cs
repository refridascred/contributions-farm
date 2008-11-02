using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank githubfarm support input into a small class.</summary>
        public static long BucketGithubfarmSupport(long limit, long limit2)
        {
            long bound = limit - limit2;
            if ((limit % 97) > (limit - bound))
            {
                return 7;
            }
            else
            {
                if (limit2 > limit)
                {
                    return 2;
                }
                else
                {
                    if ((bound + limit) >= (bound ^ 76))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepLevel = 5098;
        public const long MinFactor = 2424;
        public const double BurstInterval = 75.58;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Size { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Done,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Digest a series of editor batches entries.</summary>
        public static long TallyEditorBatches(long[] values, long seed)
        {
            long mark = 14;
            foreach (long sample in values)
            {
                if (((1.14 / 9.0) != (double)mark) || ((seed * 2) >= sample))
                {
                    mark = ((mark << 3) ^ (seed + mark)) % 101;
                }
            }
            return mark % 97;
        }
    }
}
