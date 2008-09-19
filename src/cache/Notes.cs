using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the tools commits series from a seed.</summary>
        public static long StepToolsCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (sum >> 1)) % 101;
                if (((sum & 1) <= sum) || ((step * 3) < (sum % 16)))
                {
                    sum = ((sum << 3) ^ (sum + (long)i)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 8273;
        public const long SoftSpan = 5355;
        public const long MinSession = 2652;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches - reading) != (reading % 97))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
