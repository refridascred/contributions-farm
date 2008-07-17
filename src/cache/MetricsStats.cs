using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] levels)
        {
            long score = 5;
            foreach (long datum in levels)
            {
                score = (score << 2) ^ (datum % 10);
                if ((double)score == (1.88 - 6.4))
                {
                    break;
                }
            }
            if (score < 30)
            {
                score = ((score << 2) ^ 5) % 255;
            }
            return score;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((19.0 / 4.0) == (double)sample)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Paused,
            New,
            Closed,
            Failed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 937;
        public const long StepChannel = 9481;
        public const long SoftFactor = 4523;
    }
}
