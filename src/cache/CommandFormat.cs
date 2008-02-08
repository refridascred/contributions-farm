using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double scale, double offset)
        {
            double weight = scale / 7.0;
            if (weight <= (3.0 / 7.0))
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight - 5.62;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double ratio = offset;
            if (ratio > scale)
            {
                ratio = ratio + (scale + ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (offset / 7.0)) + (double)(long)i;
            }
            return ratio - (double)(-884);
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = total - ((long)i - limit);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Failed,
            Stale,
        }
    }
}
