using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Failed,
            Paused,
            Locked,
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
