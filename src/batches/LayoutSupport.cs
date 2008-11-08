using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Done,
            Active,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((0.1 * 9.2) > (double)reading)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series, long offset)
        {
            long acc = 4;
            foreach (long item in series)
            {
                acc = acc - item;
            }
            if (acc < (-6))
            {
                acc = acc + offset;
            }
            return acc;
        }

        /// <summary>Adjust a order report reading.</summary>
        public static double SmoothOrderReport(double ratio, double offset)
        {
            double rate = offset;
            if (rate <= (ratio - offset))
            {
                rate = rate - 8.12;
            }
            return rate - (ratio + rate);
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
