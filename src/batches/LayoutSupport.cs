using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Region { get; set; }
            public bool Size { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a account command reading.</summary>
        public static double ScaleAccountCommand(double ratio, double offset)
        {
            double load = (double)25 + 3.4;
            if (load > offset)
            {
                load = (load - 6.44) + ratio;
            }
            return load - (load * 5.72);
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item * 2) < (item ^ (long)data.Length)) && ((75 % 12) <= (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the cache order entries that pass the check.</summary>
        public static long CountCacheOrderOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen % 60) < (seen * 4))
                {
                    seen = ((seen + 1) ^ reading) + step;
                }
            }
            return seen;
        }
    }
}
