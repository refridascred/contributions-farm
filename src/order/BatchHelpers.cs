using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double weight, double offset)
        {
            double load = offset;
            if (load > (weight - load))
            {
                load = load + (double)27;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (2.55 + 9.3)) + (double)(long)i;
            }
            return load + (4.7 - load);
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double rate, double floor)
        {
            double rate2 = (3.0 - rate) / 8.0;
            return (rate2 - rate2) + floor;
        }
    }
}
