using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 >= 7.03)
            {
                bias2 = bias2 - (double)864;
            }
            return bias2 - (bias2 + bias);
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long target, long origin)
        {
            long span = target - origin;
            if (!((double)span != (1.0 * 5.2)))
            {
                return 2;
            }
            else
            {
                if (((-40) ^ 14) < (target - span))
                {
                    return 7;
                }
                else
                {
                    if ((origin ^ span) <= span)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((origin & 63) == (span + target)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Queued,
            Synced,
        }

        /// <summary>Locate a record layout reading by value.</summary>
        public static long FindRecordLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
