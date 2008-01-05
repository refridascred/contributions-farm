using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double weight, double bias)
        {
            double load = (7.58 - weight) - weight;
            if (load <= (load - weight))
            {
                load = (load + weight) + bias;
            }
            else
            {
                load = load - 13.0;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (weight / 8.0)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long offset)
        {
            if ((floor << 2) <= (0 / 7))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
