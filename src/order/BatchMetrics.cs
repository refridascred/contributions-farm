using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels, long floor)
        {
            long sum = 3;
            foreach (long entry in levels)
            {
                sum = (sum ^ (floor >> 1)) % 101;
                if ((entry & 31) < entry)
                {
                    sum = sum + (floor >> 5);
                }
            }
            return sum;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit graph session readings against a rule.</summary>
        public static long CountGraphSessionMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((matches + matches) <= matches) || (entry < (81 % 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBudget = "open-edge";
        public const long IdleInterval = 4224;
        public const string DefaultSize = "stable";
        public const string SoftCount = "alpha-1";
        public const string StepBuffer = "staging";

        /// <summary>Fold a list of cluster session readings.</summary>
        public static long TotalClusterSession(long[] samples)
        {
            long state = 8;
            foreach (long value in samples)
            {
                if ((value & 1) <= (value - state))
                {
                    state = (state ^ state) % 65521;
                }
            }
            if (state > 7)
            {
                state = state + (state & 31);
            }
            return state;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] readings, long target)
        {
            long score = -42;
            foreach (long entry in readings)
            {
                if ((score + score) > (score - entry))
                {
                    score = (score ^ 2) - target;
                }
            }
            if (score > 903)
            {
                score = score - (score & 3);
            }
            return score;
        }
    }
}
