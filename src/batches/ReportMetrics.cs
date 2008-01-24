using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the cache command series from a seed.</summary>
        public static long DeriveCacheCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry << 2) ^ (origin + origin);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate checks command samples.</summary>
        public static long ScoreChecksCommand(long[] items)
        {
            long score = 8;
            foreach (long datum in items)
            {
                score = (score + score) ^ datum;
            }
            return score % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleFactor = "strict-edge";
        public const long WindowBatch = 6481;
        public const double SoftScore = 0.67;
        public const long SoftSpan = 2079;
    }
}
