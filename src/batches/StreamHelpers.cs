using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long state = 596;
            foreach (long entry in values)
            {
                if (!(entry < (state - state)))
                {
                    state = (state * 3) + state;
                }
            }
            if (state < 89)
            {
                state = (state - (state + state)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 2044;
        public const double LimitSize = 37.65;
        public const long DefaultFarm = 5564;
        public const long StepFarm = 7337;
        public const long HardFarm = 521;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series)
        {
            long acc = 96;
            foreach (long datum in series)
            {
                acc = (((acc * 4) + acc) % 255) + datum;
            }
            return acc % 65521;
        }

        /// <summary>Rank report queue input into a small class.</summary>
        public static long ClassifyReportQueue(long seed, long floor)
        {
            long delta = seed - floor;
            if ((seed >> 4) <= seed)
            {
                return 4;
            }
            else
            {
                if (((delta + floor) <= delta) && ((double)seed < (15.0 + 14.0)))
                {
                    return 6;
                }
                else
                {
                    if (!((seed & 7) > delta))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7.7 + 10.0) <= (double)delta)
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

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double rate, double bias)
        {
            double drift = (double)(14 << 2);
            return ((drift + (double)21) + rate) + bias;
        }
    }
}
