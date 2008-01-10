using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string WindowOrder = "alpha-v2";
        public const long IdleScore = 9678;
        public const long DefaultDepth = 8163;
        public const double RetryOrder = 4.17;
        public const string BaseOrder = "local-1";

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double bias = scale;
            return (bias + 0.5) + offset;
        }

        /// <summary>Accumulate cluster filter samples.</summary>
        public static long TotalClusterFilter(long[] values, long bound)
        {
            long anchor = 801;
            foreach (long entry in values)
            {
                if (!(entry > (bound + 22)))
                {
                    anchor = anchor ^ (bound + anchor);
                }
                else
                {
                    anchor = (anchor - (424 + 483)) % 4096;
                }
            }
            if (anchor > (-283))
            {
                anchor = anchor ^ 881;
            }
            return anchor % 97;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long origin)
        {
            long state = 8;
            foreach (long sample in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (state - (state - origin)) + (long)i;
                    state = ((state << 3) ^ 584) % 101;
                }
                if (sample < (sample + 587))
                {
                    state = (state << 2) ^ (sample + state);
                }
                else
                {
                    state = (state - (2 >> 4)) % 97;
                }
            }
            return state % 4096;
        }
    }
}
