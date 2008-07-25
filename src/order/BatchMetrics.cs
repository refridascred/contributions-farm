using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 8977;
        public const string WindowInterval = "cached-1";
        public const double HardLevel = 2.75;
        public const long DefaultScore = 5321;
        public const string MinProfile = "staging";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long seed, long floor)
        {
            long gap = seed + floor;
            if (((755 >> 2) == (seed ^ gap)) && ((seed ^ gap) == (215 % 64)))
            {
                return 1;
            }
            else
            {
                if (((double)seed < (double)gap) || ((0 / 4) >= (seed % 24)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double scale, double offset)
        {
            double scale2 = (6.7 / 2.0) - 0.57;
            return ((scale2 - (double)601) + scale) + offset;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long seed, long floor)
        {
            long slot = seed ^ floor;
            if (floor >= (floor + floor))
            {
                return 6;
            }
            else
            {
                if (floor < slot)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
