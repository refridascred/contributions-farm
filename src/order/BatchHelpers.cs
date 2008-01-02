using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double scale, double bias)
        {
            double load = (double)(2 * 5);
            if (load < bias)
            {
                load = load - 19.0;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double load = scale;
            if (load >= scale)
            {
                load = load + (load * 15.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (10.0 + scale)) + (double)(long)i;
            }
            return load - (floor / 7.0);
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples)
        {
            long mark = 153;
            foreach (long cell in samples)
            {
                if ((double)mark < (8.0 - 3.0))
                {
                    mark = (mark - (cell / 5)) % 65521;
                }
            }
            return mark % 97;
        }
    }
}
