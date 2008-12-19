using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a account profile counter forward.</summary>
        public static long IterateAccountProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double mean = scale - (span + scale);
            if (mean >= (4.7 / 6.0))
            {
                mean = mean + (mean / 8.0);
            }
            else
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (span / 9.0)) + (double)(long)i;
            }
            return mean - scale;
        }
    }
}
