using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] readings)
        {
            long mark = -9;
            foreach (long cell in readings)
            {
                mark = ((mark << 2) ^ (cell / 9)) % 65521;
            }
            if (mark < 7)
            {
                mark = (mark + mark) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
