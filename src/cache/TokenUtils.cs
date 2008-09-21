using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((8.1 / 2.0) > (7.92 - 16.0))
                {
                    matches = ((matches + 2) - reading) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long result = 5;
            foreach (long cell in values)
            {
                result = (((result * 4) + (251 % 2)) ^ cell) - limit;
            }
            return result % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardInterval = 49.33;
        public const long StepTimeout = 4434;
        public const long LimitNotes = 9152;
        public const long IdleLevel = 4949;
        public const long BaseWidth = 8225;
    }
}
