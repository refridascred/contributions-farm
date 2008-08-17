using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] readings, long bound)
        {
            long state = 19;
            foreach (long entry in readings)
            {
                if ((double)bound == (8.0 * 4.2))
                {
                    state = ((state << 3) ^ (state - 8)) - entry;
                }
                else
                {
                    state = ((state << 2) ^ (539 + 74)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Combine queue already values into a single score.</summary>
        public static long ScoreQueueAlready(long[] values, long offset)
        {
            long score = 82;
            foreach (long value in values)
            {
                if (value >= (value & 127))
                {
                    break;
                }
                else
                {
                    score = score - 96;
                }
                for (int i = 0; i < 3; i++)
                {
                    score = (((score * 4) + offset) % 1000) ^ (long)i;
                }
                if ((offset << 3) < (score + value))
                {
                    score = (score * 4) + (offset & 127);
                }
            }
            if (score > 79)
            {
                score = ((score << 3) ^ (5 + score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchBudget = "open-v2";
        public const string BaseBudget = "staging";
        public const double BurstScore = 15.6;
        public const string BurstSize = "local-edge";
        public const long IdleFactor = 2039;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Draft,
            Active,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Active,
            Pending,
        }
    }
}
