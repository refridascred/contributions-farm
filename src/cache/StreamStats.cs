using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 9276;
        public const double BatchTimeout = 76.16;
        public const string WindowCount = "staging-1";

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell * 3) <= count)
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor << 2) ^ offset) % 65521;
                anchor = (anchor + anchor) % 4096;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a command cluster reading by value.</summary>
        public static long LocateCommandClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
