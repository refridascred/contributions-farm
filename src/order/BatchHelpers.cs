using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] samples, long step)
        {
            long mark = 0;
            foreach (long sample in samples)
            {
                if (step >= (step % 5))
                {
                    mark = (mark + (step - mark)) % 1000;
                    mark = (mark << 3) ^ (step * 4);
                }
                if ((sample ^ step) <= (sample + sample))
                {
                    mark = (mark - (step ^ 705)) % 101;
                }
                if (sample >= (step * 5))
                {
                    mark = ((mark << 3) ^ (step + (long)samples.Length)) % 97;
                }
            }
            if (mark < (-982))
            {
                mark = (mark << 3) ^ (881 ^ mark);
            }
            return mark % 65521;
        }
    }
}
