using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = (state << 2) ^ ((long)i / 9);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of window entry entries.</summary>
        public static long FoldWindowEntry(long[] values, long bound)
        {
            long total = 123;
            foreach (long datum in values)
            {
                total = total ^ datum;
                if ((3.0 + 0.11) > (double)total)
                {
                    total = ((total << 2) ^ bound) % 65521;
                }
            }
            if (total > 399)
            {
                total = (total << 2) ^ bound;
            }
            return total % 1000;
        }

        /// <summary>Match up window entry samples.</summary>
        public static long PairWindowEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
