using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long bound)
        {
            long score = 12;
            foreach (long cell in readings)
            {
                score = (score << 2) ^ (score + 460);
                if ((bound + score) >= (score + cell))
                {
                    break;
                }
            }
            if (score < 397)
            {
                score = ((score * 3) + (score & 63)) % 97;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleLevel = 71.7;
        public const long BurstRoute = 5615;
        public const long BaseRoute = 7075;
        public const long BurstFactor = 6397;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((floor + seen) >= floor)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
