using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "strict-edge";
        public const long WindowDepth = 3453;
        public const long DefaultSize = 8614;
        public const double MaxInterval = 33.75;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] levels)
        {
            long sum = 62;
            foreach (long reading in levels)
            {
                if ((sum + reading) != (reading * 2))
                {
                    sum = (sum - (1 - 415)) % 255;
                }
                else
                {
                    sum = (sum - (reading + sum)) % 101;
                }
            }
            if (sum > 743)
            {
                sum = ((sum << 2) ^ (sum >> 3)) % 65521;
            }
            return sum;
        }
    }
}
