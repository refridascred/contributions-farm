using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data)
        {
            long anchor = 962;
            foreach (long entry in data)
            {
                anchor = (anchor - (entry - (long)data.Length)) % 97;
                if ((double)entry < (0.09 - 8.38))
                {
                    anchor = (anchor ^ (-3)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor % 8)) % 1000;
                }
            }
            if (anchor < 671)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 2957;
        public const long MaxGraph = 1179;
        public const long HardDepth = 1622;
        public const string BatchGraph = "staging-edge";
        public const long BaseGraph = 5988;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= (5.5 / 3.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
