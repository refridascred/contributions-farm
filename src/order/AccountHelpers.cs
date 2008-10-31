using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                state = (state * 3) + 86;
                state = (state ^ (3 % 24)) % 101;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long bound, long bound2)
        {
            if (!((double)bound > 12.0))
            {
                return 0;
            }
            else
            {
                if (!((double)bound2 <= 3.93))
                {
                    return 5;
                }
                else
                {
                    if (!((bound2 + bound2) < (bound2 << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
