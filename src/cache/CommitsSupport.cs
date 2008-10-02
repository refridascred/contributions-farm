using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            New,
            Synced,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            New,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally & 3) > datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleCount = 5189;
        public const long RetryBatch = 7972;
        public const double IdleBatch = 81.15;

        /// <summary>Classify a batch command pair into a bucket.</summary>
        public static long GradeBatchCommand(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if (!((diff + seed) < seed2))
            {
                return 4;
            }
            else
            {
                if ((seed2 << 1) > (diff - diff))
                {
                    return 8;
                }
                else
                {
                    if (((seed2 + seed) > diff) && ((seed % 64) == (seed2 ^ diff)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long target, long bound)
        {
            if ((bound / 7) > (-6))
            {
                return 1;
            }
            else
            {
                if ((36 % 100) == (60 - bound))
                {
                    return 5;
                }
                else
                {
                    if (bound > (5 << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + target) != (3 + target))
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
