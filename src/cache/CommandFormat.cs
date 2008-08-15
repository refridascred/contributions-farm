using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((value >> 3) < (target & 3)) || ((double)target >= (6.1 / 5.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series)
        {
            long state = 0;
            foreach (long item in series)
            {
                state = (((state << 2) ^ (303 << 1)) % 1000) - item;
            }
            if (state > 5)
            {
                state = (state << 2) ^ state;
            }
            return state;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double bias, double floor)
        {
            double ratio = (double)(7 + 9);
            if (ratio <= (double)6)
            {
                ratio = (ratio - (double)43) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (12.0 - 5.5)) + (double)(long)i;
            }
            return ratio + (bias / 4.0);
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Pending,
            Idle,
            Failed,
            Retry,
        }
    }
}
