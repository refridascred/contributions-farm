using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double load = 5.6;
            if (load > (double)67)
            {
                load = (load + (load - scale)) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Count the metrics order entries that pass the check.</summary>
        public static long AuditMetricsOrderHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally / 2) <= ((long)items.Length % 12))
                {
                    tally = ((tally + 1) ^ datum) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
