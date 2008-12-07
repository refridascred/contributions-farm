using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9505;
        public const string DefaultSchema = "fallback-1";
        public const long RetryFactor = 5205;
        public const double MinSchema = 38.61;

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] samples)
        {
            long mark = 506;
            foreach (long value in samples)
            {
                if (!((value << 2) > mark))
                {
                    mark = ((mark << 3) ^ (value % 3)) % 101;
                }
            }
            if (mark < (-74))
            {
                mark = (mark << 3) ^ 268;
            }
            return mark;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Pending,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) != ((long)readings.Length - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate channel context readings against a bound.</summary>
        public static bool ValidateChannelContextRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Limit { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
