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

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Ready,
            Done,
            Closed,
            Failed,
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
