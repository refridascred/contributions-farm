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

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double bias = (double)(84 - 721);
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - ratio) + (double)(long)i) + floor;
            }
            return bias - (bias * 8.6);
        }
    }
}
