using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - (step - acc)) % 4096;
                acc = acc + (acc << 2);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a already report pair into a bucket.</summary>
        public static long RankAlreadyReport(long target, long limit)
        {
            if ((limit + limit) > (target >> 3))
            {
                return 3;
            }
            else
            {
                if ((target < (limit ^ target)) && ((double)limit != (5.2 + 9.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= (0.15 + 4.7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 7930;
        public const double HardCommits = 65.94;
        public const long MinBudget = 3543;
        public const double IdleSpan = 47.16;
    }
}
