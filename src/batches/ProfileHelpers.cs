using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item > (393 % 12))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
