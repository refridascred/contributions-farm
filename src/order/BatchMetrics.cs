using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] values, long limit)
        {
            long mix = 697;
            foreach (long item in values)
            {
                mix = (((mix << 2) ^ (limit % 8)) % 101) + item;
            }
            if (mix < (-804))
            {
                mix = (mix + 4) % 97;
            }
            return mix;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] readings, long target)
        {
            long score = -11;
            foreach (long sample in readings)
            {
                score = ((score ^ (sample - sample)) % 101) - target;
            }
            return score % 1000;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + total) % 101;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
