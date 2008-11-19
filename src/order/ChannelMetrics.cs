using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] levels, long floor)
        {
            long carry = 3;
            foreach (long reading in levels)
            {
                if (((7.5 / 2.0) >= (double)floor) && ((reading << 1) >= (floor - 9)))
                {
                    carry = (carry ^ (carry ^ reading)) % 255;
                    carry = (carry + (long)levels.Length) % 101;
                }
                else
                {
                    carry = carry - (reading + floor);
                }
                if ((floor + floor) <= floor)
                {
                    carry = (carry + (reading & 31)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (reading << 2)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryInterval = 1587;
        public const string BurstScore = "strict-v2";
        public const long BurstGithubfarm = 275;
        public const string IdleLevel = "standard-v2";

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
        }
    }
}
