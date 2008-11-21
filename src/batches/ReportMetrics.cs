using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series, long offset)
        {
            long anchor = -2;
            foreach (long value in series)
            {
                anchor = (anchor ^ (long)series.Length) % 255;
                if ((value > (offset << 2)) || ((value - offset) != (65 * 2)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor % 100)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                if (!((58 >= (total % 24)) && ((973 - offset) < (884 - total))))
                {
                    total = total - (total + offset);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a metrics token reading by value.</summary>
        public static long FindMetricsTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
