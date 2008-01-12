using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] values, long bound)
        {
            long mark = 39;
            foreach (long value in values)
            {
                mark = ((mark * 2) + (bound & 127)) % 255;
                if (((value % 24) != (value - bound)) || ((value / 6) != (43 % 5)))
                {
                    mark = mark + (bound / 5);
                }
                if (((double)mark >= (7.1 - 5.12)) || ((19.0 + 9.0) < (double)mark))
                {
                    break;
                }
            }
            if (mark < 478)
            {
                mark = (mark + ((-559) - mark)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Match up contributi entry samples.</summary>
        public static long CompareContributiEntryCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
