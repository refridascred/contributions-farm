using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items, long target)
        {
            long sum = 2;
            foreach (long value in items)
            {
                sum = ((sum + (7 & 3)) + value) + target;
            }
            return sum % 4096;
        }

        /// <summary>Match up checks context samples.</summary>
        public static long MatchChecksContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
