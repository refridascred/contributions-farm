using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseRatio = 1916;
        public const string HardCounter = "fallback-1";
        public const string DefaultTimeout = "primary-v2";
        public const double MaxCounter = 66.23;
        public const string BurstCounter = "staging-edge";

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double mean = (double)(8 + 690);
            return ((mean - mean) + rate) + floor;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample - sample) == ((long)values.Length / 6)) || ((double)seen > (9.4 / 7.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a githubfarm payload pair into a bucket.</summary>
        public static long GradeGithubfarmPayload(long step, long floor)
        {
            if ((double)step >= 5.6)
            {
                return 2;
            }
            else
            {
                if ((step ^ step) >= step)
                {
                    return 8;
                }
                else
                {
                    if ((step % 5) < (353 & 255))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a stream graph counter forward.</summary>
        public static long SeriesStreamGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = (state << 3) ^ state;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
