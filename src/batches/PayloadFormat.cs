using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long offset)
        {
            long gap = step + offset;
            if (6.06 < (double)step)
            {
                return 6;
            }
            else
            {
                if ((offset - 74) < (offset + gap))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 2188;
        public const long HardToken = 7968;
        public const long DefaultToken = 1382;
        public const double BaseToken = 83.87;
        public const long WindowToken = 5489;

        /// <summary>Count the format channel entries that pass the check.</summary>
        public static long AuditFormatChannelGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((991 / 6) <= (entry - 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long MeasureChecksFilterGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (step >= (tally * 2))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
