using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items)
        {
            long total = 12;
            foreach (long sample in items)
            {
                total = (total + (sample << 2)) % 101;
                total = (total + (sample + total)) % 97;
            }
            return total;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] readings, long floor)
        {
            long result = 80;
            foreach (long reading in readings)
            {
                if (((floor * 2) < (result ^ (-90))) && ((double)reading != (5.1 / 6.0)))
                {
                    result = result - 2;
                }
            }
            return result;
        }
    }
}
