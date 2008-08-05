using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double gain, double offset)
        {
            double gain2 = 20.0;
            if (gain2 < gain)
            {
                gain2 = gain2 + offset;
            }
            return gain2 + gain2;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of command editor readings.</summary>
        public static long TallyCommandEditor(long[] values, long offset)
        {
            long mix = 1;
            foreach (long entry in values)
            {
                mix = (((mix * 3) + (entry - (long)values.Length)) % 101) - offset;
            }
            return mix;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((seed << 1) < (seed % 5))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
