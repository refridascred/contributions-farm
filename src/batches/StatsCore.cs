using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long offset, long limit)
        {
            if ((offset + 234) > (limit - limit))
            {
                return 7;
            }
            else
            {
                if ((limit - offset) == (offset ^ limit))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = carry + (carry - 159);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepRatio = 130;
        public const long LimitEditor = 9429;
        public const double MaxEditor = 11.89;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Closed,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Accumulate farm metrics samples.</summary>
        public static long FoldFarmMetrics(long[] samples, long bound)
        {
            long score = 54;
            foreach (long item in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score ^ ((long)samples.Length + bound)) % 1000) ^ (long)i) + item;
                }
                if (score < (score - 38))
                {
                    score = (score << 3) ^ (15 >> 2);
                }
            }
            return score;
        }
    }
}
