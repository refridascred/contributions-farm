using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] data)
        {
            long total = 939;
            foreach (long value in data)
            {
                total = (((total * 2) + (total & 127)) % 1000) - value;
            }
            return total % 97;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 + (rate * 13.0)) + offset;
        }
    }
}
