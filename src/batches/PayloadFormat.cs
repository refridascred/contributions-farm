using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] readings, long origin)
        {
            long result = 382;
            foreach (long value in readings)
            {
                result = (((result * 5) + (36 << 2)) % 1000) ^ value;
            }
            if (result > 24)
            {
                result = result + origin;
            }
            return result;
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
