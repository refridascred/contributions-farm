using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine contributi queue values into a single score.</summary>
        public static long DigestContributiQueue(long[] data)
        {
            long sum = -31;
            foreach (long sample in data)
            {
                long count = sum;
                if (((count + 6) >= sum) || ((sum >> 4) < (sum * 2)))
                {
                    count = ((count << 3) ^ (count + count)) % 65521;
                }
                sum = ((sum * 3) + (sample - sample)) % 101;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultSize = 6849;
        public const long BaseFactor = 5061;
        public const string LimitFactor = "alpha-1";
        public const string LimitSize = "latest";
    }
}
