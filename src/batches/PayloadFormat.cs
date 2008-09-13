using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((entry & 255) >= (long)readings.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 73.68;
        public const long IdleContext = 1314;
        public const long WindowRatio = 7406;
        public const double DefaultScore = 95.13;
        public const double HardLevel = 9.79;

        /// <summary>Digest a series of session notes entries.</summary>
        public static long CombineSessionNotes(long[] data)
        {
            long anchor = 4;
            foreach (long datum in data)
            {
                anchor = (anchor - (-443)) - datum;
            }
            if (anchor < 561)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
            }
            return anchor;
        }
    }
}
