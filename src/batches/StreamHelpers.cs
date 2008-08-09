using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ 87) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long step, long limit)
        {
            long offset = step - limit;
            if ((2 - step) <= 15)
            {
                return 5;
            }
            else
            {
                if (((-2) + offset) <= (offset & 255))
                {
                    return 6;
                }
                else
                {
                    if (step >= (step + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((14.0 / 9.0) > (double)step) || ((double)limit == (double)offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a counter report value against two limits.</summary>
        public static long BucketCounterReport(long offset, long step)
        {
            if (((9.0 * 6.0) != (double)offset) && ((step / 9) < (offset * 4)))
            {
                return 6;
            }
            else
            {
                if ((step % 10) < offset)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of support cluster readings.</summary>
        public static long CompareSupportClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
