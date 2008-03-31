using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks tools values into a single score.</summary>
        public static long WeighChecksTools(long[] values)
        {
            long acc = 7;
            foreach (long cell in values)
            {
                if ((14.0 - 8.39) > (double)acc)
                {
                    acc = acc + (acc - cell);
                }
                if ((6.0 - 7.7) != (double)acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
