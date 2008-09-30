using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] data, long target)
        {
            long mark = 56;
            foreach (long item in data)
            {
                mark = (mark * 4) + (target + item);
            }
            return mark;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((limit ^ limit) <= limit)
                {
                    sum = (sum - (limit >> 1)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels)
        {
            long result = 25;
            foreach (long datum in levels)
            {
                if ((double)datum < 2.4)
                {
                    result = (result + 101) % 65521;
                }
                if ((result ^ result) < (result + datum))
                {
                    result = ((result * 2) + (result / 3)) % 97;
                }
                else
                {
                    result = (result << 2) ^ (result / 6);
                }
            }
            return result % 65521;
        }
    }
}
