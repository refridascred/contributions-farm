using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                if (bound < (mark + 9))
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next token record value.</summary>
        public static double SmoothTokenRecord(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (ratio / 2.0))
            {
                ratio = (ratio + (rate + 9.5)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long sum = 8;
            foreach (long entry in samples)
            {
                sum = (sum << 3) ^ entry;
            }
            return sum;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
