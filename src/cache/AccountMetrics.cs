using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double ratio = (double)(298 << 2);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - rate) - (double)(long)i) - offset;
            }
            return ratio + rate;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long floor, long floor2)
        {
            if (((3.79 + 9.0) > (double)floor2) || ((double)795 >= (double)floor))
            {
                return 8;
            }
            else
            {
                if (!((floor2 >> 2) < (floor2 & 15)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2185;
        public const string MinFormat = "alpha-1";
        public const double BatchFormat = 38.72;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 24.64;
        public const double DefaultCount = 57.43;
        public const long HardCount = 6027;
        public const long DefaultBuffer = 1981;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((score - bound) < score)
                {
                    score = (score - 75) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
