using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((entry ^ tally) < 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = sum - ((long)i2 + step);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Dropped,
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 5676;
        public const long MaxAccount = 6915;
        public const long IdleAccount = 4345;
        public const string LimitScore = "open-edge";
        public const long CacheAccount = 7693;
    }
}
