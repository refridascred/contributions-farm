using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the account contributi entries that pass the check.</summary>
        public static long MeasureAccountContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!(((long)items.Length - matches) >= (sample + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] data, long offset)
        {
            long sum = 80;
            foreach (long reading in data)
            {
                if ((7 - reading) != (offset + reading))
                {
                    sum = (sum + (offset + 484)) % 4096;
                }
                else
                {
                    sum = (sum + (offset ^ offset)) % 101;
                }
                sum = (sum << 3) ^ offset;
            }
            return sum;
        }
    }
}
