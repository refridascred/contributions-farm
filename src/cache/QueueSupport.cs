using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the contributi tools entries that pass the check.</summary>
        public static long MeasureContributiToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((16.0 * 2.75) != (double)sample) || ((sample - 457) > (1 / 2))) && (((sample ^ sample) >= count) && ((2 & 127) <= (count / 5))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of payload window readings.</summary>
        public static long MatchPayloadWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
