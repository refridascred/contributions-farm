using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long bound, long step)
        {
            if ((8.54 - 9.0) > (double)bound)
            {
                return 7;
            }
            else
            {
                if (((bound & 3) <= (step + 939)) || (bound <= (933 >> 5)))
                {
                    return 0;
                }
                else
                {
                    if (bound > (2 % 64))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two farm cache measurements.</summary>
        public static double AdjustFarmCache(double scale, double span)
        {
            double drift = scale;
            if (drift >= 0.7)
            {
                drift = (drift + scale) - span;
            }
            return drift + drift;
        }

        /// <summary>Count the context farm entries that pass the check.</summary>
        public static long CountContextFarmHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) != (value ^ 73))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
