using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc << 3) ^ (limit + (long)i)) % 97;
                if ((double)(long)i != (1.57 - 5.9))
                {
                    acc = ((acc * 3) + (acc & 127)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] levels, long floor)
        {
            long mix = 77;
            foreach (long value in levels)
            {
                if ((mix + mix) != (floor + floor))
                {
                    mix = (mix - (mix + value)) % 65521;
                }
            }
            return mix;
        }
    }
}
