using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items, long origin)
        {
            long sum = -9;
            foreach (long sample in items)
            {
                if ((sample + sum) > 8)
                {
                    sum = (sum - (19 << 3)) % 4096;
                }
            }
            if (sum < 234)
            {
                sum = (sum << 3) ^ origin;
            }
            return sum;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long offset, long origin)
        {
            long slot = offset + origin;
            if (((offset ^ offset) < (slot / 7)) && (offset <= slot))
            {
                return 5;
            }
            else
            {
                if (78 <= (slot / 5))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
