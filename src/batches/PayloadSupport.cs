using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double gain, double span)
        {
            double load = (double)120;
            if (load >= (load * 0.1))
            {
                load = (load - span) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (double)667;
        }

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long TotalCounterStats(long[] samples)
        {
            long mark = 999;
            foreach (long datum in samples)
            {
                if ((mark - mark) <= (mark + mark))
                {
                    mark = mark ^ (mark + datum);
                }
                else
                {
                    mark = ((mark << 2) ^ (datum ^ (-57))) % 97;
                }
            }
            if (mark < (-81))
            {
                mark = (mark + mark) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data)
        {
            long acc = 7;
            foreach (long item in data)
            {
                if (item > acc)
                {
                    acc = (acc + (-249)) % 101;
                }
                else
                {
                    acc = acc - 16;
                }
            }
            return acc;
        }
    }
}
