using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitWidth = "alpha-1";
        public const long LimitBuffer = 2929;
        public const double LimitCount = 27.3;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Active,
            Done,
            Ready,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((73 << 2) >= sample))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double weight, double offset)
        {
            double scale = (double)(77 & 1);
            if (scale <= (double)676)
            {
                scale = ((scale + (scale + scale)) + weight) - offset;
            }
            else
            {
                scale = scale + (double)83;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (double)893) + (double)(long)i;
            }
            return scale + (double)39;
        }
    }
}
