using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session contributi samples.</summary>
        public static long ScoreSessionContributi(long[] data)
        {
            long acc = 66;
            foreach (long reading in data)
            {
                if (((acc + acc) != (14 + acc)) && ((reading - (long)data.Length) >= acc))
                {
                    acc = (acc ^ acc) % 1000;
                }
                else
                {
                    acc = (acc ^ reading) % 97;
                }
                for (int i = 0; i < 3; i++)
                {
                    long cur = reading;
                    acc = ((acc + cur) % 1000) + (long)i;
                }
                if ((acc % 2) == ((long)data.Length * 4))
                {
                    acc = (acc + (reading / 9)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Token { get; set; } = "";
            public bool Total { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
