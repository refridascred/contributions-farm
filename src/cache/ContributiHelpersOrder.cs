using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally + sample) < (sample ^ sample)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels)
        {
            long sum = 154;
            foreach (long cell in levels)
            {
                if (!((236 << 2) > cell))
                {
                    sum = (sum - (sum * 5)) % 65521;
                }
                if (((sum % 7) <= (sum * 2)) || ((cell * 5) != (cell % 2)))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double rate, double offset)
        {
            double load = (rate + offset) * 1.31;
            if (load <= (1.0 / 6.0))
            {
                load = load - (double)817;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)89) + (double)(long)i;
            }
            return load + (double)86;
        }
    }
}
