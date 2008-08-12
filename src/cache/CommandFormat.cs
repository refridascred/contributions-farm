using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((item / 9) <= (offset + offset)) || ((item - seen) >= (item % 16))) || (((double)871 <= (double)offset) && (3.9 > (double)item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long result = 64;
            foreach (long item in readings)
            {
                if (((3.8 + 2.0) >= (double)item) || ((7.3 - 3.3) <= (double)result))
                {
                    result = ((result * 2) + (result + result)) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (result % 10);
                }
            }
            if (result > 867)
            {
                result = result - (result >> 5);
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 5992;
        public const string SoftFarm = "standard-1";
        public const long LimitLevel = 396;
    }
}
