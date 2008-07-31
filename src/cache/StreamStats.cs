using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of counter stream readings.</summary>
        public static long OverlapCounterStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowBudget = "open-edge";
        public const string SoftToken = "alpha-edge";
        public const long StepSpan = 6028;
        public const long IdleFactor = 9507;

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double ratio, double offset)
        {
            double load = (offset * 5.36) * 1.38;
            if (load < offset)
            {
                load = load + load;
            }
            else
            {
                load = load + ratio;
            }
            return load - ratio;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 87.7;
        public const double CacheNotes = 92.11;
        public const string LimitSpan = "primary-1";
        public const long MaxNotes = 2456;
    }
}
