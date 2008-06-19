using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first profile checks entry that matches the target.</summary>
        public static long LookupProfileChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Locked,
            Queued,
            Paused,
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
