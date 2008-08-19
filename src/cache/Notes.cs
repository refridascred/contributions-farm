using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long origin)
        {
            long carry = 161;
            foreach (long cell in series)
            {
                if ((carry << 3) <= origin)
                {
                    carry = ((carry - (origin ^ origin)) % 255) - cell;
                }
            }
            if (carry > 8)
            {
                carry = (carry * 5) + (origin / 5);
            }
            return carry;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double weight = 18.0 + (offset + offset);
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (offset / 8.0)) - (double)(long)i) - scale;
            }
            return weight + (weight * 8.2);
        }

        /// <summary>Locate a route counter reading by value.</summary>
        public static long FindRouteCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
