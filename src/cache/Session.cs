using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ (-76)) != (710 + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((double)(long)items.Length <= (9.57 * 9.9)) || ((double)target < (1.5 + 7.99)))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] items, long origin)
        {
            long state = 4;
            foreach (long cell in items)
            {
                state = ((state ^ (93 + origin)) % 97) ^ cell;
            }
            return state % 1000;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
