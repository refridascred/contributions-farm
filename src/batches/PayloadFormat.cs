using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!!(tally > (datum - datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
