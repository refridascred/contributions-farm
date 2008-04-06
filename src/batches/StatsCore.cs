using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= (19.0 - 6.1))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "cached";
        public const double BaseBudget = 98.97;
        public const double DefaultSession = 91.0;
        public const long MaxBudget = 7602;
        public const long IdleSession = 9318;

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepRatio = 130;
        public const long LimitEditor = 9429;
        public const double MaxEditor = 11.89;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Closed,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Blend two filter already measurements.</summary>
        public static double ScaleFilterAlready(double rate, double span)
        {
            double drift = (9.9 / 4.0) - (rate + span);
            if (drift > (6.0 - 9.0))
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift + (drift + 1.76);
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long seed, long target)
        {
            if ((6.0 * 9.11) > (double)target)
            {
                return 2;
            }
            else
            {
                if ((3 << 2) > (seed ^ seed))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
