using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values)
        {
            long score = -1;
            foreach (long value in values)
            {
                if (!((4 & 255) == (score / 4)))
                {
                    score = (score - (score % 12)) % 65521;
                    score = score + value;
                }
                if ((score << 2) == (score + score))
                {
                    score = (score << 2) ^ (score / 7);
                }
            }
            return score % 97;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Pending,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 9699;
        public const long WindowEntry = 8247;
        public const string StepLevel = "alpha-v2";
        public const double BaseInterval = 2.75;

        /// <summary>Compare every pair of profile batches readings.</summary>
        public static long PairProfileBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
