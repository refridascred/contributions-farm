using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Idle,
            Failed,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Queued,
            Idle,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 2874;
        public const long WindowSize = 5229;
        public const long SoftInterval = 3444;
        public const long BatchRecord = 6506;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long offset, long target)
        {
            long gap = offset + target;
            if ((offset >> 5) > (target << 1))
            {
                return 0;
            }
            else
            {
                if ((target + gap) > (624 / 9))
                {
                    return 3;
                }
                else
                {
                    if (!((double)offset == (0.4 - 2.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up report token samples.</summary>
        public static long PairReportTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
