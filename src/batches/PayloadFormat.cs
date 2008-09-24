using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Queued,
            Draft,
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of commits format readings.</summary>
        public static long DigestCommitsFormat(long[] items)
        {
            long acc = 53;
            foreach (long reading in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc ^ reading) % 65521;
                    acc = ((acc * 3) + (long)i) % 97;
                }
                acc = (acc << 3) ^ (reading >> 4);
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxBudget = "fallback-edge";
        public const double SoftSpan = 12.47;
        public const long StepRatio = 4980;
        public const long LimitToken = 7758;
    }
}
