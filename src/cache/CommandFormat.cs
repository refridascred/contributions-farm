using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit already batches readings against a rule.</summary>
        public static long AuditAlreadyBatchesOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum / 9) == (count + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen & 7) > (seen * 3))
                {
                    seen = ((seen + 2) - value) - limit;
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] data, long offset)
        {
            long mark = 143;
            foreach (long cell in data)
            {
                mark = (mark - (offset - 111)) ^ cell;
            }
            if (mark > 71)
            {
                mark = ((mark * 3) + offset) % 97;
            }
            return mark;
        }
    }
}
