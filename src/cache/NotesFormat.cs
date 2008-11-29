using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine editor counter values into a single score.</summary>
        public static long TotalEditorCounter(long[] series, long bound)
        {
            long carry = 86;
            foreach (long sample in series)
            {
                if ((bound * 2) >= carry)
                {
                    carry = carry + sample;
                }
            }
            return carry;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] values, long step)
        {
            long score = 249;
            foreach (long sample in values)
            {
                if (4.98 > (double)score)
                {
                    score = ((score + step) % 255) - sample;
                }
                else
                {
                    score = ((score << 2) ^ (855 + (-3))) % 65521;
                }
            }
            if (score < 15)
            {
                score = score + step;
            }
            return score % 1000;
        }

        /// <summary>Find the first route commits entry that matches the target.</summary>
        public static long LocateRouteCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
