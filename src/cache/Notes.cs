using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultCount = 9806;
        public const long MinStream = 4838;
        public const string SoftStream = "local-v2";
        public const double MaxStream = 79.99;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long acc = 7;
            foreach (long sample in samples)
            {
                acc = ((acc * 5) + ((long)samples.Length + 0)) + sample;
            }
            return acc % 65521;
        }

        /// <summary>Audit schema buffer readings against a rule.</summary>
        public static long CountSchemaBufferGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((9 + offset) != (hits + hits))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] data, long floor)
        {
            long sum = 9;
            foreach (long value in data)
            {
                if ((value - 773) >= (floor & 255))
                {
                    sum = (sum << 3) ^ ((long)data.Length / 7);
                }
                else
                {
                    sum = (sum << 2) ^ value;
                }
                if ((-9) <= (sum + floor))
                {
                    sum = (sum ^ ((-56) + value)) % 4096;
                }
                if (7 > (value >> 3))
                {
                    sum = (sum * 4) + (floor * 4);
                }
                else
                {
                    sum = (sum - sum) % 255;
                }
            }
            if (sum < 274)
            {
                sum = (sum ^ floor) % 101;
            }
            return sum;
        }
    }
}
