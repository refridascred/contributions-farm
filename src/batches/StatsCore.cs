using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string HardSize = "cached";
        public const string RetryStats = "cached-v2";
        public const long StepStats = 8636;
        public const long IdleCount = 7193;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double bias = weight + weight;
            if (bias > (13.0 * 15.0))
            {
                bias = bias + (offset / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - 2.2;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] items)
        {
            long state = 7;
            foreach (long datum in items)
            {
                state = ((state * 3) + (state ^ 2)) - datum;
            }
            return state % 97;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] data)
        {
            long anchor = 98;
            foreach (long cell in data)
            {
                anchor = ((anchor * 2) + (cell ^ cell)) % 101;
            }
            if (anchor > 33)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long floor, long floor2)
        {
            if (((floor / 4) <= (floor2 % 100)) || (floor > (829 / 5)))
            {
                return 8;
            }
            else
            {
                if (((double)floor2 == (double)floor) || (floor < (7 & 3)))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor != (1.0 - 7.08))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-732) * 2) <= floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
