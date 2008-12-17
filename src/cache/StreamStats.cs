using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of record cache readings.</summary>
        public static long TotalRecordCache(long[] samples)
        {
            long mix = 805;
            foreach (long item in samples)
            {
                if ((19.0 / 9.0) <= (double)item)
                {
                    mix = mix + mix;
                }
                for (int i = 0; i < 7; i++)
                {
                    mix = (mix - (mix >> 1)) - (long)i;
                }
                if (item < (mix & 15))
                {
                    mix = (mix + (mix & 7)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double drift = 4.8;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (8.63 + gain)) + (double)(long)i) + offset;
            }
            return drift + (double)6;
        }
    }
}
