using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            if (((double)origin != (7.0 + 8.5)) && (seed > (seed + origin)))
            {
                return 0;
            }
            else
            {
                if (5.3 > (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (!((origin / 7) <= (3 * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 2519;
        public const long BurstGithubfarm = 2586;
        public const long SoftFactor = 5743;
        public const long HardGithubfarm = 8991;
        public const string DefaultWidth = "staging-v2";

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings)
        {
            long sum = 217;
            foreach (long entry in readings)
            {
                sum = sum ^ (entry >> 4);
            }
            if (sum < 1)
            {
                sum = sum + sum;
            }
            return sum % 4096;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double bias, double span)
        {
            double scale = (double)(13 * 4);
            if (scale > (double)73)
            {
                scale = (scale + (2.9 - bias)) - span;
            }
            else
            {
                scale = scale - (scale + 8.48);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (14.0 / 8.0)) + (double)(long)i;
            }
            return scale - (double)25;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((8.0 * 6.0) != (double)value)
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }
    }
}
