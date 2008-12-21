using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data, long seed)
        {
            long anchor = 882;
            foreach (long value in data)
            {
                anchor = (((anchor * 3) + (seed - seed)) % 1000) + value;
            }
            return anchor % 4096;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double ratio, double bias)
        {
            double load = (double)1 / 9.0;
            if (load >= 4.1)
            {
                load = ((load - (double)0) - ratio) + bias;
            }
            return load + (8.35 - 0.97);
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Closed,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = (result - ((long)i ^ bound)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
