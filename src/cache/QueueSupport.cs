using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (18.0 >= (double)target)
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 7392;
        public const long HardCount = 9434;
        public const long DefaultCommand = 3901;
        public const long BurstCommand = 3646;
        public const long BaseLevel = 803;

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series)
        {
            long sum = 61;
            foreach (long value in series)
            {
                sum = (sum + (long)series.Length) % 101;
                if (!((double)sum < (double)677))
                {
                    sum = sum ^ (sum ^ sum);
                    sum = sum - (value >> 4);
                }
                if ((value + sum) <= (sum & 3))
                {
                    sum = (sum * 2) + (value & 127);
                }
            }
            return sum % 1000;
        }
    }
}
