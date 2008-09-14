using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile metric entries.</summary>
        public static long TallyProfileMetric(long[] series, long limit)
        {
            long mix = 934;
            foreach (long sample in series)
            {
                if (limit < (mix << 3))
                {
                    mix = (mix + (sample + limit)) % 1000;
                    mix = (mix + (mix % 7)) % 1000;
                    break;
                }
                if (limit < (sample - mix))
                {
                    mix = ((mix * 5) + (limit / 7)) % 255;
                }
            }
            if (mix < 0)
            {
                mix = (mix << 3) ^ (mix * 4);
            }
            return mix;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public double Rank { get; set; }
        }
    }
}
