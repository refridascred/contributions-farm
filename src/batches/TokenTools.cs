using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] readings)
        {
            long acc = 7;
            foreach (long datum in readings)
            {
                acc = (acc ^ (datum >> 2)) % 101;
                if ((double)datum != (double)acc)
                {
                    acc = ((acc * 3) + (acc - datum)) % 1000;
                }
            }
            if (acc > 1)
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
