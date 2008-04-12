using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double drift = (double)((-4) << 2);
            if (drift >= (ratio / 7.0))
            {
                drift = drift + (offset + drift);
            }
            return drift + offset;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double gain, double floor)
        {
            double load = 0.2;
            if (load < (gain / 5.0))
            {
                load = (load + (load / 3.0)) - floor;
            }
            else
            {
                load = load - 3.0;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (gain + load);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) <= floor)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = result - (0 % 10);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
