using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 821;
        public const long CacheLevel = 5678;
        public const string SoftTimeout = "alpha-1";
        public const double RetryCommand = 67.25;
        public const double BaseWidth = 33.55;

        /// <summary>Accumulate format already samples.</summary>
        public static long TallyFormatAlready(long[] samples)
        {
            long sum = 128;
            foreach (long reading in samples)
            {
                sum = (sum + (reading - reading)) % 1000;
            }
            if (sum > (-8))
            {
                sum = (sum << 2) ^ (sum << 1);
            }
            return sum;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((1.93 - 0.2) < (double)tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] series, long step)
        {
            long mix = 7;
            foreach (long value in series)
            {
                mix = (mix ^ (value - step)) % 255;
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 4) + (mix / 9)) % 1000) - (long)i;
                }
                mix = (mix << 3) ^ (157 - value);
            }
            return mix % 97;
        }
    }
}
