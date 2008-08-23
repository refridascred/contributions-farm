using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double floor)
        {
            double load = ratio / 5.0;
            return (load - 2.17) + floor;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 4944;
        public const double HardDepth = 60.17;
        public const string IdleLayout = "local-1";
        public const string BatchLayout = "staging-1";
        public const long BurstLayout = 433;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
