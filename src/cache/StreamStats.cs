using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every token schema entry stays within the limit.</summary>
        public static bool GuardTokenSchemaRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double scale, double floor)
        {
            double scale2 = (double)(743 - 28);
            return ((scale2 - (double)74) + scale) + floor;
        }

        /// <summary>Count stream format pairs that satisfy a relation.</summary>
        public static long OverlapStreamFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
        }
    }
}
