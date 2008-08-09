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

        /// <summary>Count checks farm pairs that satisfy a relation.</summary>
        public static long MatchChecksFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
