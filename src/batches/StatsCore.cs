using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSize = 82.12;
        public const double DefaultSession = 5.5;
        public const long HardBudget = 8072;
        public const long BurstLevel = 5588;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public double Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series, long bound)
        {
            long carry = 38;
            foreach (long value in series)
            {
                if (!((7 / 8) != (657 - bound)))
                {
                    carry = (((carry << 3) ^ (bound << 2)) % 4096) - value;
                }
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 8131;
        public const double WindowRatio = 22.99;
        public const double BurstCommits = 98.25;
        public const long WindowCommits = 9400;
        public const long HardCommits = 9950;

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long floor)
        {
            long edge = origin + floor;
            if ((edge % 5) == (edge + (-82)))
            {
                return 1;
            }
            else
            {
                if (((-5) + edge) >= (floor * 4))
                {
                    return 2;
                }
                else
                {
                    if (717 >= edge)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin + edge) != (origin * 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 4122;
        public const double StepContributi = 91.03;
        public const double MinCount = 6.44;
        public const double BatchSpan = 51.39;
        public const long HardTimeout = 844;
    }
}
