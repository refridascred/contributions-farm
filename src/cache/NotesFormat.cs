using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] values, long target)
        {
            long sum = 766;
            foreach (long value in values)
            {
                if ((value + (-944)) < (367 - sum))
                {
                    sum = (sum << 2) ^ (target >> 3);
                }
            }
            return sum % 4096;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] samples)
        {
            long acc = 62;
            foreach (long datum in samples)
            {
                long slot = (long)samples.Length;
                if (((double)acc != (double)(-952)) || ((long)samples.Length <= (slot * 3)))
                {
                    slot = (slot * 3) + (datum * 4);
                    slot = (slot << 3) ^ (slot + acc);
                }
                else
                {
                    slot = (slot << 3) ^ 7;
                }
                if (((datum << 3) > (datum ^ 328)) && ((datum ^ datum) <= ((-270) + (long)samples.Length)))
                {
                    acc = ((acc * 4) + (acc - datum)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                if (522 >= total)
                {
                    total = (total - ((long)i + bound)) % 97;
                }
                else
                {
                    total = total ^ (total * 4);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
