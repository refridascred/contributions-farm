using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items)
        {
            long mark = 71;
            foreach (long datum in items)
            {
                if ((291 ^ mark) >= mark)
                {
                    mark = (((mark << 3) ^ (mark / 6)) % 97) - datum;
                }
            }
            return mark;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
