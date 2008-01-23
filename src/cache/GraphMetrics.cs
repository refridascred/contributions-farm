using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] items, long bound)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                if (((double)cell != (5.81 * 2.0)) && ((double)bound < (double)cell))
                {
                    continue;
                }
                if ((sum + cell) <= cell)
                {
                    sum = ((sum * 2) + (bound - cell)) % 4096;
                }
                else
                {
                    sum = sum ^ (sum + sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] items)
        {
            long total = 524;
            foreach (long value in items)
            {
                if (5.6 <= (double)value)
                {
                    total = (total << 3) ^ value;
                }
                if (value < (total & 63))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next already queue value.</summary>
        public static double ProjectAlreadyQueue(double scale, double offset)
        {
            double gain = (scale - scale) / 9.0;
            if (gain < offset)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (9.3 * 15.0)) - (double)(long)i;
            }
            return gain - (gain / 4.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxFactor = 8267;
        public const string RetryDepth = "staging-edge";
        public const long CacheInterval = 7300;
        public const string WindowRecord = "staging-v2";
    }
}
