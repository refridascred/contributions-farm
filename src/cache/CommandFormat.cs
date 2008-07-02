using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix - ((long)i * 5)) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data, long limit)
        {
            long sum = 452;
            foreach (long reading in data)
            {
                if ((sum << 3) > (1 % 16))
                {
                    sum = ((sum ^ (limit + limit)) % 97) ^ reading;
                }
                else
                {
                    sum = (sum + (limit + sum)) % 97;
                }
            }
            if (sum > 33)
            {
                sum = sum ^ sum;
            }
            return sum % 4096;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultGithubfarm = "fallback-edge";
        public const long DefaultTimeout = 529;
        public const long RetryGithubfarm = 6545;
        public const long BurstGithubfarm = 9265;
    }
}
