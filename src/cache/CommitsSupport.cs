using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double scale = (double)(41 - 6);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + (bias * 14.0)) + (double)(long)i) - weight;
            }
            return scale - 11.0;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long floor, long target)
        {
            long cur = floor + target;
            if ((floor + (-54)) == (floor * 2))
            {
                return 3;
            }
            else
            {
                if ((target - cur) != (cur - 120))
                {
                    return 2;
                }
                else
                {
                    if ((902 % 64) >= target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)cur != (double)483)
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
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)limit < (9.0 - 7.82))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Idle,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
