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

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample & 127) <= (sample >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
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

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public long Count { get; set; }
        }
    }
}
