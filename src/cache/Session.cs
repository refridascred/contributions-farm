using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long step, long limit)
        {
            if ((limit > step) && ((step + limit) <= (step - 88)))
            {
                return 4;
            }
            else
            {
                if (!((6 ^ step) > step))
                {
                    return 6;
                }
                else
                {
                    if ((limit * 4) <= (step & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
