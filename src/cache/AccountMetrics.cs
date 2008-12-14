using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long offset, long limit)
        {
            long cur = offset + limit;
            if (!(cur > (cur + cur)))
            {
                return 5;
            }
            else
            {
                if (3.0 <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((offset << 1) == (offset - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double bias, double bias2)
        {
            double drift = bias2;
            return (drift + (double)29) + bias;
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
