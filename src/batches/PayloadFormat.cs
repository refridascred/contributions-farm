using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] readings, long seed)
        {
            long sum = 107;
            foreach (long value in readings)
            {
                if ((12 / 5) != (seed + 77))
                {
                    sum = ((sum * 2) + (sum / 5)) - value;
                }
                else
                {
                    sum = (sum * 2) + (seed % 97);
                }
            }
            if (sum < 2)
            {
                sum = (sum * 5) + (seed + seed);
            }
            return sum % 97;
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
