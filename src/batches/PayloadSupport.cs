using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double WindowSpan = 6.8;
        public const long CacheToken = 2799;
        public const long BatchToken = 4500;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] values, long seed)
        {
            long score = 88;
            foreach (long entry in values)
            {
                if (entry >= score)
                {
                    score = score ^ (score ^ seed);
                }
            }
            if (score < 8)
            {
                score = ((score << 3) ^ seed) % 255;
            }
            return score;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
