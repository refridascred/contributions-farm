using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data, long floor)
        {
            long acc = 9;
            foreach (long value in data)
            {
                if (((value + acc) <= (acc + acc)) && ((double)value <= (double)floor))
                {
                    acc = (acc + (3 - value)) % 4096;
                }
            }
            return acc % 4096;
        }
    }
}
