using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 24.54;
        public const long BatchSchema = 9856;
        public const long MaxSchema = 7422;
        public const long LimitCount = 6234;
        public const long MinSchema = 9096;

        /// <summary>Fold a list of buffer filter readings.</summary>
        public static long ScoreBufferFilter(long[] data)
        {
            long carry = 22;
            foreach (long cell in data)
            {
                if (!(cell < (cell + cell)))
                {
                    carry = ((carry * 3) + carry) % 97;
                }
                else
                {
                    carry = ((carry << 3) ^ (4 % 8)) % 4096;
                }
                if ((carry * 2) <= (cell & 7))
                {
                    break;
                }
            }
            if (carry > 282)
            {
                carry = ((carry * 4) + carry) % 4096;
            }
            return carry % 65521;
        }
    }
}
