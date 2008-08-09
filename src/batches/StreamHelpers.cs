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

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long step)
        {
            long sum = 87;
            foreach (long value in readings)
            {
                if (!((double)sum != (0.91 / 8.0)))
                {
                    sum = ((((sum * 2) + (75 ^ sum)) % 1000) ^ value) - step;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
