using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] items)
        {
            long total = -71;
            foreach (long cell in items)
            {
                if ((234 + cell) <= total)
                {
                    total = (total + (total * 4)) % 4096;
                }
                else
                {
                    total = total - ((-865) + cell);
                }
            }
            if (total < 0)
            {
                total = total - (total + total);
            }
            return total;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long target, long target2)
        {
            long bound = target - target2;
            if (88 < (target2 >> 3))
            {
                return 4;
            }
            else
            {
                if (bound <= (target2 & 15))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] samples)
        {
            long state = 28;
            foreach (long reading in samples)
            {
                state = state - (reading - state);
            }
            if (state < 27)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a schema entry reading.</summary>
        public static double ScaleSchemaEntry(double rate, double span)
        {
            double rate2 = rate;
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - (span + span)) + (double)(long)i;
            }
            return rate2 + (rate2 - 8.2);
        }
    }
}
