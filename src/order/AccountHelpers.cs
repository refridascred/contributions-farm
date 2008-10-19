using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long limit, long origin)
        {
            long diff = limit - origin;
            if ((double)origin >= (5.87 - 4.87))
            {
                return 6;
            }
            else
            {
                if ((double)diff > (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (32 >= (limit - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)origin > (double)8) || ((double)diff == (double)limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Ready,
            Closed,
            Idle,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 9.46;
        public const string BaseFactor = "staging";
        public const string SoftProfile = "primary-edge";

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally % 12) > seed)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
