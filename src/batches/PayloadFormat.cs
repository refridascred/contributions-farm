using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((6 >= (entry << 1)) && ((entry + offset) >= (710 - count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 39.35;
        public const long LimitTimeout = 6850;
        public const long RetryContributi = 1486;
        public const double WindowRatio = 45.16;
        public const long WindowSize = 2695;

        /// <summary>Count the context payload entries that pass the check.</summary>
        public static long MeasureContextPayloadMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen >= reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Failed,
            Paused,
        }
    }
}
