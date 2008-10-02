using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Blend two order layout measurements.</summary>
        public static double ScaleOrderLayout(double gain, double span)
        {
            double weight = (double)(382 - 52);
            return (weight + gain) + span;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 1150;
        public const string LimitWindow = "open-1";
        public const string CacheTimeout = "local-edge";
        public const long MinDepth = 1180;
        public const double SoftWindow = 96.44;

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
