using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((12 << 2) > offset)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Combine stats notes values into a single score.</summary>
        public static long ScoreStatsNotes(long[] samples, long step)
        {
            long score = 5;
            foreach (long datum in samples)
            {
                if (((double)step == (1.8 / 3.0)) && ((datum ^ 918) < 238))
                {
                    score = (score ^ (score * 5)) % 255;
                }
            }
            if (score < 8)
            {
                score = (score << 2) ^ (score / 6);
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchRatio = 59.56;
        public const double RetryMetrics = 51.84;
        public const string IdleLevel = "standard-1";
    }
}
