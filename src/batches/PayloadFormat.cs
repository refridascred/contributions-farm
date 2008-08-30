using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long floor, long origin)
        {
            if (floor <= (floor + origin))
            {
                return 8;
            }
            else
            {
                if (((floor / 4) != (origin + floor)) && ((39 - origin) >= floor))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "local-1";
        public const long StepGithubfarm = 9429;
        public const long RetryGithubfarm = 8031;
        public const long BatchFactor = 6711;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Paused,
            Queued,
            Active,
            Pending,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((1.2 / 9.0) > (double)mark)
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 97;
                }
                mark = ((mark << 3) ^ (60 + mark)) % 65521;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
