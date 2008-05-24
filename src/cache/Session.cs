using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double ratio, double span)
        {
            double rate = (span * 4.7) - (ratio * 1.2);
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (span * 0.3)) + (double)(long)i;
            }
            return rate + (ratio + rate);
        }

        /// <summary>Combine counter stream values into a single score.</summary>
        public static long DigestCounterStream(long[] levels)
        {
            long carry = -1;
            foreach (long value in levels)
            {
                carry = ((carry ^ (874 / 4)) % 255) + value;
            }
            if (carry > 5)
            {
                carry = (carry + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            New,
            Done,
            Failed,
        }
    }
}
