using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the channel route series from a seed.</summary>
        public static long SeriesChannelRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (sum ^ ((long)i2 - (long)i)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitInterval = 4872;
        public const long IdleCommits = 6506;
        public const long SoftCount = 2448;
        public const string WindowCommits = "open-1";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(10.0 > (double)seen))
                {
                    seen = ((seen + 1) ^ entry) + offset;
                }
            }
            return seen;
        }
    }
}
