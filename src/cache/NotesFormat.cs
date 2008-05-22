using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] levels)
        {
            long mark = 204;
            foreach (long item in levels)
            {
                if (((item / 9) >= (mark / 5)) && ((mark / 9) > (mark & 1)))
                {
                    mark = (mark + (648 + 80)) % 97;
                }
                if (((double)mark != (double)4) || ((item + item) >= (item - item)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = mix + (long)i;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] values)
        {
            long sum = 2;
            foreach (long value in values)
            {
                if ((4.48 + 7.3) > (double)sum)
                {
                    sum = ((sum ^ (sum - 7)) % 101) + value;
                }
            }
            if (sum > 62)
            {
                sum = (sum ^ (sum + sum)) % 1000;
            }
            return sum % 4096;
        }
    }
}
