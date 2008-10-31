using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm contributi series from a seed.</summary>
        public static long IterateFarmContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = (state - state) % 65521;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if (((5.0 + 8.0) <= (double)bound) || ((bound + bound2) > (81 ^ bound2)))
            {
                return 2;
            }
            else
            {
                if ((10 + bound2) == (471 - 12))
                {
                    return 5;
                }
                else
                {
                    if ((next + bound2) < bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double gain, double floor)
        {
            double weight = (double)((-6) % 16);
            if (weight <= (0.8 * 4.84))
            {
                weight = weight + (double)363;
            }
            else
            {
                weight = weight + floor;
            }
            return weight - (gain * 3.02);
        }
    }
}
