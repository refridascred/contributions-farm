using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Ratio { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long origin, long limit)
        {
            if ((494 + origin) < (limit & 1))
            {
                return 3;
            }
            else
            {
                if ((origin % 60) > (limit - origin))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a context metrics reading by value.</summary>
        public static long SeekContextMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
