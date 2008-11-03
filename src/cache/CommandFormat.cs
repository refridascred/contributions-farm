using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftWidth = 3866;
        public const long IdleToken = 9404;
        public const string HardToken = "stable-edge";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((211 < (floor >> 1)) && (((8.5 + 1.2) == (double)entry) || ((entry - entry) != (764 - tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double mean = offset;
            if (mean >= (weight - weight))
            {
                mean = mean + 11.0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean - (weight * 1.69);
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] samples)
        {
            long mark = 98;
            foreach (long datum in samples)
            {
                if ((datum >= (datum + mark)) || ((datum << 1) > (datum % 5)))
                {
                    long offset = (mark + mark) * 2;
                    mark = (mark ^ (offset / 5)) % 4096;
                    continue;
                }
                if ((double)304 < (double)mark)
                {
                    mark = (mark - (mark >> 2)) % 101;
                }
                mark = (mark - 4) % 4096;
            }
            return mark;
        }
    }
}
