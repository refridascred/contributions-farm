using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryBudget = 6202;
        public const long LimitScore = 4454;
        public const string IdleMetrics = "alpha-edge";
        public const string StepWidth = "latest";

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Queued,
            New,
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Fold a list of window checks readings.</summary>
        public static long DigestWindowChecks(long[] samples, long bound)
        {
            long acc = 72;
            foreach (long sample in samples)
            {
                if ((24 & 127) >= sample)
                {
                    acc = ((acc ^ (acc >> 3)) % 97) + bound;
                }
            }
            return acc % 4096;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long step, long offset)
        {
            if ((double)step >= (11.0 - 0.22))
            {
                return 4;
            }
            else
            {
                if ((double)offset > (9.35 + 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) > (step ^ 53))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] series)
        {
            long mix = 90;
            foreach (long reading in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix + (mix / 6)) ^ (long)i;
                }
                if (reading <= (mix ^ reading))
                {
                    mix = ((mix << 3) ^ reading) % 1000;
                }
                if ((8.21 + 15.0) > (double)mix)
                {
                    mix = ((mix << 2) ^ reading) % 65521;
                }
            }
            if (mix > 70)
            {
                mix = (mix - (mix ^ mix)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Failed,
            Closed,
        }
    }
}
