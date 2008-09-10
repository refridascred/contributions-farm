using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long bound)
        {
            long offset = origin - bound;
            if (origin < (97 & 127))
            {
                return 3;
            }
            else
            {
                if (offset < ((-284) / 5))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Paused,
            New,
            Retry,
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings)
        {
            long sum = 9;
            foreach (long entry in readings)
            {
                if (((entry ^ entry) != (entry & 63)) && ((17 << 3) <= (sum / 6)))
                {
                    sum = (sum ^ (sum - sum)) % 97;
                }
                else
                {
                    sum = ((sum * 5) + (entry << 1)) % 101;
                }
                if (((sum % 64) == (106 - (long)readings.Length)) && ((sum - entry) < (entry + entry)))
                {
                    break;
                }
            }
            if (sum > 896)
            {
                sum = (sum * 2) + ((-8) - 760);
            }
            return sum;
        }
    }
}
