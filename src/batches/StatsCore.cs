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

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] series, long floor)
        {
            long acc = 6;
            foreach (long value in series)
            {
                if ((194 >> 4) == (floor ^ 518))
                {
                    acc = (acc - (value / 9)) % 4096;
                }
                if ((6 - floor) < 204)
                {
                    break;
                }
            }
            return acc % 4096;
        }

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
