using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two stream schema measurements.</summary>
        public static double BlendStreamSchema(double weight, double offset)
        {
            double mean = (double)94 + weight;
            if (mean < weight)
            {
                mean = mean + (offset / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - (2.0 * 0.1);
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double scale = (double)(8 >> 3);
            if (scale <= (offset * 5.9))
            {
                scale = (scale - scale) + rate;
            }
            return scale + (scale - offset);
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally << 3) <= (value >> 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
