using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long step, long step2)
        {
            if (step2 <= ((-571) << 1))
            {
                return 3;
            }
            else
            {
                if (((step / 4) > (step2 << 3)) || ((step + step2) > step2))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Queued,
            Done,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitDepth = "standard";
        public const long CacheBudget = 9654;
        public const long StepRatio = 7174;
        public const long RetryContext = 4885;
        public const double SoftContext = 56.72;

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
