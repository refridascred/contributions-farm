using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 17.55;
        public const long HardCache = 4787;
        public const long MinScore = 8260;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            New,
            Done,
            Closed,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Failed,
            Done,
        }

        /// <summary>Digest a series of buffer support entries.</summary>
        public static long TotalBufferSupport(long[] values)
        {
            long anchor = 7;
            foreach (long item in values)
            {
                if ((anchor % 60) == (anchor & 255))
                {
                    anchor = ((anchor << 3) ^ (item - anchor)) % 97;
                }
            }
            if (anchor > 93)
            {
                anchor = (anchor * 2) + (anchor / 6);
            }
            return anchor % 65521;
        }
    }
}
