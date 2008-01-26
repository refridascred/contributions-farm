using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Label { get; set; }
            public double Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long step, long floor)
        {
            if ((double)floor >= (2.0 / 6.0))
            {
                return 8;
            }
            else
            {
                if (((step - step) > (floor << 1)) && ((step ^ step) != (floor % 5)))
                {
                    return 7;
                }
                else
                {
                    if (step < 4)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step < 48) || ((double)floor >= 6.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a channel notes figure with a bias.</summary>
        public static double AdjustChannelNotes(double bias, double bias2)
        {
            double scale = bias2;
            return (scale - (0.6 / 7.0)) + bias;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
