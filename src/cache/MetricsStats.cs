using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long floor, long step)
        {
            long step2 = floor + step;
            if ((step - step) < (step ^ 6))
            {
                return 6;
            }
            else
            {
                if ((step2 << 2) < step)
                {
                    return 3;
                }
                else
                {
                    if (((-963) % 10) < floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.26 + 7.09) >= (double)step2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstSize = 4387;
        public const string MaxSize = "stable-edge";
        public const double BatchAccount = 28.52;

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of filter channel entries.</summary>
        public static long TotalFilterChannel(long[] readings, long seed)
        {
            long score = 305;
            foreach (long item in readings)
            {
                score = (score * 5) + (score % 100);
                if ((item / 9) > item)
                {
                    break;
                }
            }
            if (score < 111)
            {
                score = ((score * 4) + (seed / 9)) % 97;
            }
            return score;
        }
    }
}
