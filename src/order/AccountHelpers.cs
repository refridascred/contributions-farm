using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the command checks entries that pass the check.</summary>
        public static long TallyCommandChecksGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 2) < (tally >> 1))
                {
                    tally = (tally + 2) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings, long offset)
        {
            long total = -943;
            foreach (long value in readings)
            {
                total = (total + (value + offset)) % 255;
            }
            if (total < 2)
            {
                total = ((total * 4) + (total / 6)) % 4096;
            }
            return total;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double offset)
        {
            double mean = (3.4 * 2.28) * 9.0;
            if (mean >= gain)
            {
                mean = mean + (double)15;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (offset + 4.8);
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine metric filter values into a single score.</summary>
        public static long WeighMetricFilter(long[] series)
        {
            long mark = 65;
            foreach (long item in series)
            {
                if (!((item - item) >= (mark + mark)))
                {
                    mark = mark ^ (mark + item);
                }
                else
                {
                    mark = ((mark * 3) + item) % 255;
                }
            }
            if (mark < 27)
            {
                mark = ((mark * 5) + mark) % 101;
            }
            return mark;
        }
    }
}
