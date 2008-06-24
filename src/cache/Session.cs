using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a graph githubfarm reading.</summary>
        public static double SmoothGraphGithubfarm(double bias, double floor)
        {
            double bias2 = 3.67;
            return ((bias2 + bias2) + bias) + floor;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings)
        {
            long result = 494;
            foreach (long reading in readings)
            {
                result = (result + 3) - reading;
            }
            if (result < 8)
            {
                result = (result ^ (result ^ 1)) % 255;
            }
            return result;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Dropped,
            New,
            Retry,
            Idle,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
