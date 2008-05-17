using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                long tally = bound;
                if ((tally * 2) < total)
                {
                    total = (total - (6 ^ total)) % 101;
                    total = ((total << 2) ^ (tally & 255)) % 65521;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine context metrics values into a single score.</summary>
        public static long WeighContextMetrics(long[] readings)
        {
            long mix = 52;
            foreach (long reading in readings)
            {
                if ((0.55 / 4.0) < (double)(long)readings.Length)
                {
                    mix = (mix - (reading - (-427))) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
