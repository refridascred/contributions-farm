using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of support session entries.</summary>
        public static long CombineSupportSession(long[] samples)
        {
            long state = 334;
            foreach (long value in samples)
            {
                if ((double)value >= (1.1 + 3.9))
                {
                    break;
                }
                if ((value / 4) <= (0 - value))
                {
                    state = (state ^ state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count != (18.0 + 3.1))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits <= (577 + (long)series.Length))
                {
                    hits = ((hits + 1) ^ datum) + target;
                }
            }
            return hits;
        }
    }
}
