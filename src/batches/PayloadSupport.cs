using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLevel = 4079;
        public const long DefaultBudget = 135;
        public const long MinLayout = 3614;

        /// <summary>Count notes window pairs that satisfy a relation.</summary>
        public static long OverlapNotesWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema format samples are out of range.</summary>
        public static long TallySchemaFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((851 + 2) > (matches << 3))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
