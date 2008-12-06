using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ offset) % 4096;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "legacy";
        public const double MaxBudget = 17.46;
        public const long MaxChannel = 5829;
        public const long MinChannel = 8405;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen < (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a support commits counter forward.</summary>
        public static long StepSupportCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i <= (868 >> 2))
                {
                    score = (score ^ 380) % 101;
                    continue;
                }
                if ((666 ^ limit) <= limit)
                {
                    score = ((score << 2) ^ (long)i) % 4096;
                }
                else
                {
                    score = score ^ (limit + score);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Draft,
            Paused,
            Retry,
        }
    }
}
