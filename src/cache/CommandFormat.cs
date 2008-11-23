using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Find the first batches window entry that matches the target.</summary>
        public static long LookupBatchesWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report contributi reading.</summary>
        public static double AdjustReportContributi(double ratio, double offset)
        {
            double drift = (ratio - offset) + ratio;
            if (drift < drift)
            {
                drift = drift + (drift * 2.77);
            }
            return drift - (double)0;
        }

        /// <summary>Derive the next account stream value from a seed.</summary>
        public static long IterateAccountStream(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if (((double)target >= (4.8 - 3.3)) || (((-968) + target) == (score ^ score)))
                {
                    score = (score * 5) + (target + score);
                }
                else
                {
                    score = (score + score) % 255;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
