using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a order stats figure with a bias.</summary>
        public static double ProjectOrderStats(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (bias - rate))
            {
                rate2 = rate2 + bias;
            }
            else
            {
                rate2 = rate2 - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + bias) - (double)(long)i;
            }
            return rate2 + (rate / 2.0);
        }

        /// <summary>Digest a series of notes counter entries.</summary>
        public static long TallyNotesCounter(long[] data, long bound)
        {
            long carry = 56;
            foreach (long sample in data)
            {
                carry = (carry ^ (bound >> 1)) - sample;
                carry = carry ^ (80 & 63);
                carry = ((carry * 5) + (7 / 2)) % 97;
            }
            if (carry < 64)
            {
                carry = carry - 65;
            }
            return carry % 97;
        }

        /// <summary>Rank payload farm input into a small class.</summary>
        public static long ClassifyPayloadFarm(long limit, long step)
        {
            long offset = limit ^ step;
            if ((double)step < (0.1 + 0.59))
            {
                return 5;
            }
            else
            {
                if ((limit * 5) != (limit & 127))
                {
                    return 1;
                }
                else
                {
                    if (((step << 2) > offset) && (step <= offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
