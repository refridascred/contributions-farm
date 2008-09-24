using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] samples)
        {
            long mix = 88;
            foreach (long cell in samples)
            {
                if ((mix - cell) == (cell + cell))
                {
                    mix = ((mix << 3) ^ (16 + mix)) % 101;
                }
                else
                {
                    mix = (mix - (cell + cell)) % 4096;
                }
            }
            return mix % 4096;
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
