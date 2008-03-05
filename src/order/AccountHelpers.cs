using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Find the first format commits entry that matches the target.</summary>
        public static long LocateFormatCommitsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout route values into a single score.</summary>
        public static long TotalLayoutRoute(long[] items)
        {
            long mix = 613;
            foreach (long sample in items)
            {
                if (((mix - mix) == (mix * 5)) && ((sample + sample) >= (mix + sample)))
                {
                    mix = (mix << 2) ^ (mix ^ mix);
                }
            }
            if (mix < 3)
            {
                mix = (mix - (62 + mix)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((2.47 * 3.0) > (double)hits)
                {
                    hits = ((hits + 1) + item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
