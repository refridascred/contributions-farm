using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long limit, long floor)
        {
            long gap = limit + floor;
            if (7.0 > (double)gap)
            {
                return 7;
            }
            else
            {
                if (!(floor >= gap))
                {
                    return 1;
                }
                else
                {
                    if ((double)gap <= (12.0 + 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor > 7.7)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleTimeout = 64.93;
        public const double StepInterval = 14.82;
        public const string LimitLevel = "stable-v2";
        public const string LimitSession = "fallback-1";
        public const double WindowSession = 30.59;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] data, long limit)
        {
            long result = 638;
            foreach (long item in data)
            {
                result = (((result * 2) + (result ^ result)) % 255) - limit;
                if (result <= item)
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
