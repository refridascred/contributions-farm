using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((1 * 4) >= (214 ^ datum)) && ((927 ^ datum) <= (datum / 7)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor << 3) ^ 498;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
