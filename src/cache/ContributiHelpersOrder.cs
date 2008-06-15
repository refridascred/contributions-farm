using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a editor record counter forward.</summary>
        public static long SeriesEditorRecord(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum ^ (bound & 7)) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of batch window readings.</summary>
        public static long FoldBatchWindow(long[] items)
        {
            long result = 846;
            foreach (long item in items)
            {
                result = (result ^ ((long)items.Length + 2)) - item;
            }
            return result;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long mark = 380;
            foreach (long value in values)
            {
                mark = (mark + ((-9) + value)) % 1000;
            }
            return mark % 65521;
        }
    }
}
