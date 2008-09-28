using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double load = (floor - scale) - (floor / 6.0);
            if (load >= (double)2)
            {
                load = load - floor;
            }
            else
            {
                load = load - (double)22;
            }
            return load + (8.0 / 2.0);
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
