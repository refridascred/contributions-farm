using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] items)
        {
            long acc = 3;
            foreach (long value in items)
            {
                if ((acc >= (acc / 9)) || ((acc / 9) <= (value + acc)))
                {
                    acc = acc ^ (value - value);
                }
            }
            return acc;
        }

        /// <summary>Project the next batches contributi value.</summary>
        public static double BlendBatchesContributi(double ratio, double floor)
        {
            double load = ratio / 4.0;
            if (load < load)
            {
                load = load - (ratio * 6.67);
            }
            else
            {
                load = load + (floor + load);
            }
            return load + load;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long bound)
        {
            long span = offset + bound;
            if ((span ^ offset) > (span + 159))
            {
                return 6;
            }
            else
            {
                if ((2.5 * 9.66) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((477 <= offset) || ((bound % 100) >= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
