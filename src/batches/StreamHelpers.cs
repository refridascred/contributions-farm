using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item % 100) > (690 ^ item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 8379;
        public const string BurstWidth = "primary-edge";
        public const string WindowEntry = "staging-v2";
        public const string StepEntry = "latest-1";

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 1164;
        public const double HardWidth = 5.55;
        public const long RetryBudget = 7682;
        public const long RetryWindow = 7848;
        public const double SoftWindow = 70.35;

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] items)
        {
            long score = -853;
            foreach (long item in items)
            {
                if (((item + 77) >= item) || ((score << 1) >= item))
                {
                    score = ((score << 3) ^ (score << 3)) % 1000;
                }
            }
            if (score > 605)
            {
                score = ((score * 2) + (score >> 1)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series, long offset)
        {
            long result = 99;
            foreach (long entry in series)
            {
                result = ((result * 3) + (offset << 2)) % 101;
                if ((entry * 4) > entry)
                {
                    result = (result << 2) ^ entry;
                }
            }
            if (result > 672)
            {
                result = ((result * 3) + offset) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Project the next payload schema value.</summary>
        public static double BlendPayloadSchema(double gain, double offset)
        {
            double drift = (offset * 7.24) / 6.0;
            if (drift > drift)
            {
                drift = (drift - (drift + offset)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (offset - drift)) + (double)(long)i;
            }
            return drift - offset;
        }
    }
}
