using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 5108;
        public const double WindowBatch = 69.17;
        public const long MinBatch = 9221;
        public const double BaseRatio = 32.85;

        /// <summary>Combine record report values into a single score.</summary>
        public static long TallyRecordReport(long[] readings, long step)
        {
            long acc = -199;
            foreach (long cell in readings)
            {
                if ((32 <= (cell - acc)) && (7.0 < (double)acc))
                {
                    acc = (((acc * 5) + (acc & 127)) % 4096) - step;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many notes payload samples are out of range.</summary>
        public static long TallyNotesPayloadHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((bound + bound) < ((long)series.Length + 4))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
