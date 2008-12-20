using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the record stream entries that pass the check.</summary>
        public static long MeasureRecordStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 3) <= (4 + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double gain = (bias * 1.0) + (bias * 5.6);
            if (gain > bias)
            {
                gain = gain - (bias - rate);
            }
            else
            {
                gain = gain - (rate / 4.0);
            }
            return gain - (double)31;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
