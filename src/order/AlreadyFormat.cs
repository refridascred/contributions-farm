using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] samples)
        {
            long mark = 2;
            foreach (long value in samples)
            {
                mark = mark - (value & 63);
                mark = (mark + (mark + value)) % 4096;
                mark = mark - (value & 63);
            }
            return mark;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Mode { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double load = floor;
            if (load > floor)
            {
                load = (load - (floor * 17.0)) - ratio;
            }
            else
            {
                load = load - (floor / 8.0);
            }
            return load - floor;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
