using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardInterval = 9505;
        public const long CacheCommand = 2003;
        public const long StepDepth = 240;
        public const long WindowCommand = 1558;
        public const long BaseCommand = 9532;

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double ratio, double offset)
        {
            double drift = (offset * 6.4) - 7.23;
            if (drift <= 4.79)
            {
                drift = drift + (5.7 + ratio);
            }
            else
            {
                drift = drift + (20.0 - ratio);
            }
            return drift + (offset - offset);
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values, long seed)
        {
            long state = 506;
            foreach (long datum in values)
            {
                state = (state * 4) + (seed << 2);
                if (!((seed - datum) != (state ^ 7)))
                {
                    state = (state + seed) % 255;
                }
                state = (state * 5) + (8 << 2);
            }
            if (state > 75)
            {
                state = (state ^ (seed / 7)) % 4096;
            }
            return state;
        }
    }
}
