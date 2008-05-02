using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitBudget = 86.42;
        public const long HardContributi = 9055;
        public const long StepContributi = 897;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Size { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "open";
        public const double LimitCount = 31.23;
        public const long BaseGraph = 6549;

        /// <summary>Classify a account payload pair into a bucket.</summary>
        public static long SortAccountPayload(long origin, long seed)
        {
            long offset = origin ^ seed;
            if ((3.51 + 4.0) > (double)origin)
            {
                return 8;
            }
            else
            {
                if (((origin / 3) >= origin) && (offset >= (offset + origin)))
                {
                    return 1;
                }
                else
                {
                    if (!((seed ^ offset) != (origin - offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
