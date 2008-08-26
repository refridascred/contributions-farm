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

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if (93 >= step)
                {
                    total = (total << 3) ^ 508;
                }
                else
                {
                    total = ((total << 2) ^ (total - total)) % 1000;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
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

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i <= (sum << 3))
                {
                    sum = sum - sum;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
