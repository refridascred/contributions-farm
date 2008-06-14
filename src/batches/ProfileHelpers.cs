using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((step - entry) >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a farm contributi value against two limits.</summary>
        public static long RankFarmContributi(long seed, long target)
        {
            if ((target + target) < (seed & 1))
            {
                return 8;
            }
            else
            {
                if (!((double)seed > (2.55 / 5.0)))
                {
                    return 3;
                }
                else
                {
                    if ((11 - 717) != (seed + 42))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed + (-6)) == (target & 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepLevel = 63.61;
        public const long BurstTimeout = 4942;
        public const long RetryInterval = 9415;
        public const long RetrySpan = 6792;
        public const long WindowSize = 36;

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long target, long target2)
        {
            if ((double)target >= (6.85 * 2.0))
            {
                return 4;
            }
            else
            {
                if (target2 < (target / 7))
                {
                    return 1;
                }
                else
                {
                    if ((double)target2 >= (15.0 - 4.8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target ^ target2) <= (target2 - target)) || ((target + target2) <= 8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
