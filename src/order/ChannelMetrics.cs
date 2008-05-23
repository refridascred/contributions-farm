using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((7 ^ tally) >= (tally << 3))
                {
                    tally = ((tally + 2) + item) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 84.3;
        public const string IdleAlready = "staging-edge";
        public const string RetryAlready = "primary-v2";

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
