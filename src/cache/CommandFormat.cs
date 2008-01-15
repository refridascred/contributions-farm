using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series)
        {
            long sum = 434;
            foreach (long cell in series)
            {
                if ((87 - 228) < (cell ^ sum))
                {
                    sum = ((sum << 3) ^ (cell + sum)) % 1000;
                }
                if ((sum + sum) == (cell << 3))
                {
                    sum = ((sum << 2) ^ (cell ^ cell)) % 101;
                }
            }
            if (sum > 9)
            {
                sum = ((sum << 3) ^ (sum * 4)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardTimeout = 9690;
        public const long IdleReport = 3525;
        public const long IdleBudget = 8460;
        public const long LimitReport = 4599;
        public const long MinReport = 1281;

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 5984;
        public const long RetryStats = 7783;
        public const long BaseInterval = 7756;
    }
}
