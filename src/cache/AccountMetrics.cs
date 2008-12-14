using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate layout report readings against a bound.</summary>
        public static bool GuardLayoutReportRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double offset)
        {
            double weight = 3.58 * 1.53;
            if (weight >= (weight + bias))
            {
                weight = weight + (double)4;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight - (double)70;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 5159;
        public const double BatchTimeout = 80.69;
        public const string BatchCommits = "standard";
        public const long SoftRatio = 2300;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Closed,
            Dropped,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            Locked,
            Ready,
            Draft,
        }
    }
}
