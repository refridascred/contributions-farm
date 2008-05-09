using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of layout graph entries.</summary>
        public static long ScoreLayoutGraph(long[] samples)
        {
            long carry = 450;
            foreach (long value in samples)
            {
                if (!((carry - 4) <= (value + value)))
                {
                    carry = ((carry << 2) ^ carry) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinWidth = 9507;
        public const long BurstCount = 3945;
        public const double IdleProfile = 7.15;
        public const double BaseSize = 77.28;
        public const long CacheDepth = 2505;

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values, long offset)
        {
            long acc = 58;
            foreach (long reading in values)
            {
                acc = (acc + (reading * 4)) % 255;
            }
            if (acc > 141)
            {
                acc = (acc << 3) ^ offset;
            }
            return acc % 65521;
        }
    }
}
