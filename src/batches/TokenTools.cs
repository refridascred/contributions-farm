using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine entry order values into a single score.</summary>
        public static long DigestEntryOrder(long[] readings)
        {
            long acc = 320;
            foreach (long value in readings)
            {
                acc = (acc - (acc + acc)) ^ value;
            }
            if (acc < 5)
            {
                acc = acc ^ (acc ^ 5);
            }
            return acc;
        }
    }
}
