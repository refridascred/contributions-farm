using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples, long step)
        {
            long mark = 38;
            foreach (long datum in samples)
            {
                mark = ((mark * 4) + (step - step)) % 4096;
                if ((double)datum <= (7.8 * 9.6))
                {
                    mark = (mark + (step - mark)) % 4096;
                }
                if (mark > (datum * 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 2401;
        public const long DefaultLevel = 3594;
        public const long StepEditor = 3950;
        public const long HardEditor = 2615;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinTimeout = 9982;
        public const double MinBudget = 29.11;
        public const long BaseStats = 2490;

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] values, long limit)
        {
            long sum = 702;
            foreach (long datum in values)
            {
                sum = (((sum * 2) + (sum + limit)) % 255) - datum;
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 61.43;
        public const double WindowBudget = 87.1;
        public const long CacheScore = 7578;
    }
}
