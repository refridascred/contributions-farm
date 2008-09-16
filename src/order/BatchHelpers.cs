using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a checks command counter forward.</summary>
        public static long StepChecksCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of token cache readings.</summary>
        public static long TotalTokenCache(long[] items)
        {
            long total = 0;
            foreach (long reading in items)
            {
                if ((reading >= (192 + total)) || ((reading + reading) == (reading & 31)))
                {
                    total = total - (reading + reading);
                }
            }
            if (total < 789)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxWidth = 9706;
        public const double RetryFormat = 20.17;
        public const long WindowFormat = 3267;
        public const long MinLevel = 3498;
        public const long DefaultInterval = 4289;
    }
}
